using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A test NPC
public class ExampleNPC : MonoBehaviour
{
    private Node startNode;
    private Conversation convText;
    // Start is called before the first frame update
    void Start()
    {
        NodeCreate();
        convText = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Conversation>();
    }

    void NodeCreate()
    {
        //First you have to make a start node, which all other nodes in the conversation somehow link to
        startNode = new Node("This is the first node.");
        //Then we create a new subnode. Note that the string arg of these Nodes is what will display in the main text area in the conversation view.
        Node option1 = new Node("This is what happens when you select option 1.", startNode);
        //Now that we've made our new Node, we need to add it as an option to our startNode. The string arg of adding an option is what will display on the button that will coorespond with this option.
        startNode.AddOption("Option 1", option1);

        //Now we will make another node, so that there are multiple options from our startNode
        Node option2 = new Node("This is what happens when you select option 2.", startNode);
        //When we add this Node as an option, we will include a third argument. 
        //This third argument is a special unique string, that will be checked against a block of IF statements in Conversation.cs, in the CodeExecute() function
        //This way we can have our conversations trigger any kind of code we want
        startNode.AddOption("Option 2", option2, "ExampleCode");
        
        //Now we are going to add a suboption to one of our option Nodes, to demonstrate how we can go as deep as we want with the Nodes and connections
        //Youll also see below, that we use a special Rich Text Tag to set the color of one of our words. The Nodes print out to a UI element that supports rich text tags, so you can spruce up your nodes with these.
        Node sub1option2 = new Node("This is a <color=#7ee7f7>sub</color> option of option 2.", startNode);
        option2.AddOption("Sub Option 2", sub1option2);

        //lastly, we will add an Option with no node attached. This will treat the option as an exit button, leaving the conversation when clicked (note: you can have these "exit buttons" trigger codes as well)
        startNode.AddOption("Leave Conversation");


    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.tag=="Player" && Input.GetButton("Talk"))
        {
            convText.StartConversation(startNode);
        }
    }
}
