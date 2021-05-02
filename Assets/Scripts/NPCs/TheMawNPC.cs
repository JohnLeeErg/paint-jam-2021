using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheMawNPC : ExampleNPC
{
    Node EndNodes;
    protected override void NodeCreate()
    {
        startNode = new Node("Hello Little Soup Goblin, I have summoned you here for a very important task. You must bring to the Maw a sacrifice, from one of the nearby islands. The Campbell Tomato Soup Must Be Sated");
        startNode.AddOption("Yes Master...");
        startNode.AddOption("As you wish, wise and powerful Campbell Babe...");
        startNode.AddOption("I will Obey");
        startNode.AddOption("ahh, if it must be so...");

        EndNodes = new Node("Ahh, little goblin, you have returned with an offering. Is this truly who you think is fit for The Maw?");

        EndNodes.AddOption("Yes, this is who I choose to send forth to Cambhell");
        EndNodes.AddOption("No, on second thought, I have made an error, forgive me, Goddess","end");
        EndNodes.AddOption("Am I not a worthy Sacrifice? Take Me Instead!!", "self");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
