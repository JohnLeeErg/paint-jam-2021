using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadCultist : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Sniff... Sniff... Can you leave me alone?");



        //option what
        Node option1 = new Node("Did you not hear what I asked?", startNode);
        option1.AddOption("no", startNode);

        Node option1sub1 = new Node("Unsoicited help is no help at all"); 
        option1.AddOption("I want to help", option1);

        option1sub1.AddOption("I guess ill leave then");

        option1.AddOption("Can you repeat the request?", startNode);
        startNode.AddOption("What happend?", option1);


        //option what
        Node option2 = new Node("Clearly not, as you can see! I was attacked", startNode);
        startNode.AddOption("Are you ok?", option1);

        Node option2sub1 = new Node("");



        startNode.AddOption("Okay sorry for disturbing you");
        startNode.AddOption("Leave Conversation");
    }
}
