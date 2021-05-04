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
        startNode = new Node("Hello, little <color=#5DA45D>Soup Goblin</color>. I have summoned you here for a very important task. You must bring to <color=#8B0000>The Maw</color> a <color=#F00000>Sacrifice</color> from one of the nearby islands. <color=#8B0000>The Maw</color> must be sated.");
        startNode.AddOption("Yes, Master...", "enableBoat");
        startNode.AddOption("As you wish, oh wise and powerful Campbell Babe...", "enableBoat");
        startNode.AddOption("I will obey.", "enableBoat");
        startNode.AddOption("If it must be so...", "enableBoat");

        MidNode = new Node("Where is the <color=#F00000>Sacrifice</color>, <color=#5DA45D>Goblin</color>? Do you wish to incur the wrath of <color=#8B0000>The Maw</color>? GO FORTH, AND FIND A WORTHY OFFERING. Do not return without one.");
        MidNode.AddOption("[Bow and scurry off]");
        MidNode.AddOption("[Prostrate yourself and apologize]");
        MidNode.AddOption("[Silently leave, head held low]");

        EndNode = new Node("Ahh, little <color=#5DA45D>Goblin</color>, finally you have returned with an offering. Is this truly who you think is fit to be devoured by <color=#8B0000>The Maw</color>?");

        EndNode.AddOption("Yes, this is who I choose to send forth to CambHell", "end");
        EndNode.AddOption("No, on second thought, I have made an error. Please forgive me, Goddess...");
        EndNode.AddOption("Am I not a worthy <color=#F00000>Sacrifice</color>? Please, take me instead!", "self");
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
