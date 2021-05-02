using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMoustachioTrickedOut : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("[They're still sobbing uncontrollably. Maybe you shouldn't have tricked them like that...]");
        startNode.AddOption("[Leave Conversation]");
    }
}
