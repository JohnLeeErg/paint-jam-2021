using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    [SerializeField] private UIController UIcont;
    [SerializeField] private Canvas UIcanvas;
    private Node[,] nodeMap;
    private Node startNode;
    private Node curNode;
    public string playerName = "Oscar";

    //SEE EXAMPLE NPC FOR MORE INFORMATION ON CREATING NODES

    public void StartConversation(Node firstNode)
    {
        loadNode(firstNode);
        UIcanvas.enabled = true;
    }

    void LeaveConversation()
    {
        UIcanvas.enabled = false;
    }

    void loadNode(Node toLoad)
    {
        curNode = toLoad;
        string[] optsText = new string[curNode.options.Count];
        for (int x = 0; x < optsText.Length; x++)
        {
            optsText[x] = curNode.options[x].text;
        }

        UIcont.SetScreen(curNode.text, optsText);
    }

    public void ButtonPressed(int butNum)
    {
        if (butNum < curNode.options.Count)
        {
            //check for a code to execute
            string code = "";
            if (curNode.options[butNum].code == "nothing")
            {
                //do nothing
            }
            else
            {
                code = curNode.options[butNum].code;
            }
            CodeExecute(code);

            //then check if we are going to another node or quitting
            if (curNode.options[butNum].isQuit)
            {
                LeaveConversation();
            }
            else
            {
                loadNode(curNode.options[butNum].linkNode);
            }
        }
        else
        {
            Debug.Log("Button pressed for a node that does not exist.");
        }
    }

    private void CodeExecute(string code)
    {
        if (code == "mushroomPick")
        {
            //here is where you make mushrooms do stuff
            nodeMap[4, 6].RemoveOption(nodeMap[4, 6].options[3]);
        }
        else if (code == "stealTomato")
        {
            //
        }
    }

    
}

public class Node
{
    public string text;
    public bool isMain;
    public List<Option> options;

    public Node(string text, Node parent)
    {
        this.text = text;
        options = new List<Option>();
        options.Add(new Option("[Go Back]", parent));
        isMain = false;
    }
    public Node(string text)
    {
        this.text = text;
        options = new List<Option>();
        isMain = true;
    }
    public void AddOption(string text, Node child)
    {
        options.Add(new Option(text, child));
    }

    public void AddOption(string text, Node child, string code)
    {
        options.Add(new Option(text, child, code));
    }
    public void AddOption(string text)
    {
        options.Add(new Option(text));
    }

    public void AddOption(string text, string code)
    {
        options.Add(new Option(text, code));
    }

    public void RemoveOption(Option toRemove)
    {
        options.Remove(toRemove);
    }
}

public class Option
{
    public Node linkNode;
    public string text, code;
    public bool isQuit;

    public Option(string text, Node linkNode)
    {
        this.text = text;
        this.linkNode = linkNode;
        this.code = "nothing";
        this.isQuit = false;
    }

    public Option(string text, Node linkNode, string code)
    {
        this.text = text;
        this.linkNode = linkNode;
        this.code = code;
        this.isQuit = false;
    }
    public Option(string text) //if an option has no attached node, it is assumed that choosing that option will exit the conversation
    {
        this.text = text;
        this.code = "nothing";
        this.isQuit = true;
    }
    public Option(string text, string code) //if an option has no attached node, it is assumed that choosing that option will exit the conversation
    {
        this.text = text;
        this.code = code;
        this.isQuit = true;
    }
}