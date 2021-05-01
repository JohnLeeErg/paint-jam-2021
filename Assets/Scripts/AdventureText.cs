using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureText : MonoBehaviour
{
    [SerializeField] private UIController UIcont;
    [SerializeField] private Transform player;
    private Node[,] nodeMap;
    private Node startNode;
    private Node curNode;
    private string playerName = "Oscar";
    // Start is called before the first frame update
    void Start()
    {
        //loadNode(startNode);
    }

    void testNodes()
    {
        startNode = new Node("This is the first node, this has player coords attached to it.", new Vector2(0, 0));
        Node option1 = new Node("This is what happens when you select option 1.", startNode);
        startNode.AddOption("Option 1", option1);
        Node option2 = new Node("This is what happens when you select option 2.", startNode);
        startNode.AddOption("Option 2", option2);
        Node sub1option2 = new Node("This is a sub option of option 2.", startNode);
        option2.AddOption("Sub Option 2", sub1option2);

        Node nextNode = new Node("This is an example of another major node with coords attached.", new Vector2(1, 1));
        startNode.AddOption("Head North", nextNode);
        nextNode.AddOption("Head South", startNode);

    }

    void loadNode(Node toLoad)
    {
        curNode = toLoad;
        string[] optsText = new string[curNode.options.Count];
        for (int x = 0; x < optsText.Length; x++)
        {
            optsText[x] = curNode.options[x].text;
        }

        if(curNode.isMain && player != null)
        {
            player.position = curNode.playerCoords;
        }

        UIcont.SetScreen(curNode.text, optsText);
    }

    public void ButtonPressed(int butNum)
    {
        if (butNum < curNode.options.Count)
        {
            string code = "";
            if (curNode.options[butNum].code == "nothing")
            {
                //do nothing
            }
            else
            {
                code = curNode.options[butNum].code;
            }

            loadNode(curNode.options[butNum].linkNode);
            CodeExecute(code);
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
    public Vector2 playerCoords;


    public Node(string text, Node parent)
    {
        this.text = text;
        options = new List<Option>();
        options.Add(new Option("[Go Back]", parent));
        isMain = false;
    }
    public Node(string text, Vector2 playerCoords)
    {
        this.text = text;
        this.playerCoords = playerCoords;
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

    public void RemoveOption(Option toRemove)
    {
        options.Remove(toRemove);
    }
}

public class Option
{
    public Node linkNode;
    public string text, code;

    public Option(string text, Node linkNode)
    {
        this.text = text;
        this.linkNode = linkNode;
        this.code = "nothing";
    }

    public Option(string text, Node linkNode, string code)
    {
        this.text = text;
        this.linkNode = linkNode;
        this.code = code;
    }
}
