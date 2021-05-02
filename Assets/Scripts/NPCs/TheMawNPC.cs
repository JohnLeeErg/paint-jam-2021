using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheMawNPC : ExampleNPC
{
    Node EndNode;
    bool deliveredFirstDialogue = false;
    Node MidNode;
    RiseFromSeaWhenNearPlayer riseRef;
    [SerializeField] PassengerManager passengerManager;
    private void Awake()
    {
        riseRef = GetComponent<RiseFromSeaWhenNearPlayer>();
    }

    protected override void NodeCreate()
    {
        startNode = new Node("Hello Little Soup Goblin, I have summoned you here for a very important task. You must bring to the Maw a sacrifice, from one of the nearby islands. The Campbell Tomato Soup Must Be Sated");
        startNode.AddOption("Yes Master...", "enableBoat");
        startNode.AddOption("As you wish, wise and powerful Campbell Babe...", "enableBoat");
        startNode.AddOption("I will Obey", "enableBoat");
        startNode.AddOption("ahh, if it must be so...","enableBoat");

        MidNode = new Node("Where is the sacrifice, Goblin? You don't wish to incur Campbell's Wrath do you? Then go forth, and find a worthy offering.");
        MidNode.AddOption("bow and scurry off");
        MidNode.AddOption("prostate yourself and apologize");
        MidNode.AddOption("silently leave, head low");

        EndNode = new Node("Ahh, little goblin, you have returned with an offering. Is this truly who you think is fit for The Maw?");

        EndNode.AddOption("Yes, this is who I choose to send forth to Cambhell", "end");
        EndNode.AddOption("No, on second thought, I have made an error, forgive me, Goddess");
        EndNode.AddOption("Am I not a worthy Sacrifice? Take Me Instead!!", "self");
    }
    // Update is called once per frame
    private void Update()
    {
        if (!deliveredFirstDialogue)
        {
            passengerManager.DisaleBoatInput();
            if (riseRef.risen)
            {
                convText.StartConversation(startNode);
                deliveredFirstDialogue = true;
            }
        }
        else
        {
            if (passengerManager.currentPassenger == null)
            {

                ConvoUpdate(MidNode);
            }
            else
            {
                ConvoUpdate(EndNode);
            }
        }
    }

}
