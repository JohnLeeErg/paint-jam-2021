using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOnRockNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("It seems there is a mouse sitting here on top of this rock. It doesn't seem to be at all bothered by your presence.");
        Node boat = new Node("The mouse squeaks at you and doesn't move. You don't even know if the mouse would qualify for sacrifice.", startNode);
        Node cheese = new Node("The mouse gets excited at the word \"cheese\", but doesn't seem to grasp the more abstract notion of it being somewhere else.", boat);
        Node soul = new Node("I don't know what you were expecting... The mouse squeaks...", boat);

        startNode.AddOption("\"Do you wanna come on my boat?\"", boat);

        boat.AddOption("\"I have cheese on my boat...\"", cheese);
        boat.AddOption("\"Hey mouse, do you have a soul?\"", soul);

        soul.AddOption("Squeak at the mouse, and leave.");

        cheese.AddOption("\"Farewell mouse...\"");

        startNode.AddOption("\"Uuhh, goodbye mouse.\"");
    }

}
