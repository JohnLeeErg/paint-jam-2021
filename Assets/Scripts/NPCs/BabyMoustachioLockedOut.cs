using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMoustachioLockedOut : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("[They're still sobbing uncontrollably. You really shouldn't have been so hard on the kid...]");
        startNode.AddOption("[Leave Conversation]");
    }
}
