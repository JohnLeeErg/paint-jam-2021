using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOnRockNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("It seems there is a mouse sitting here on top of this rock. It doesn't seem to be at all bothered by your presence");

        startNode.AddOption("\"Uuhh, goodbye mouse.\"");
    }

}
