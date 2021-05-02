using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroolyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Hah, what are you doing in this shithole?");

        startNode.AddOption("\"Sorry, I gotta split.\"");
    }

}

