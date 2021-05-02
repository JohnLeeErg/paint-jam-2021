using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumbyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Myeah? Hey there.");

        startNode.AddOption("\"Sorry, I gotta leave.\"");
    }

}
