using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoustacheKidHappy : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Hey, you got my can back! Thank you so much! Baby Moustachio can cry all day, I'm keeping MY can that I got all by MYself! I got it fair and square!");

        // Acceptance
        Node acceptance = new Node("Sure, let's go!");
        acceptance.AddOption("[Take them to the boat]", transform);

        startNode.AddOption("Ask if they want to go on a boat ride", acceptance);
        startNode.AddOption("[Leave Conversation]");
    }
}
