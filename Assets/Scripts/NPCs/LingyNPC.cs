using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LingyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Oh- Hey- Whatsup? Long time no see...");

        startNode.AddOption("\"Sorry, I gotta split.\"");
    }

}
