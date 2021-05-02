using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("You there! Knocking on my door! I know what you're here for!!");

        startNode.AddOption("\"Alright, I'm leaving now.\"");
    }

}
