using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogKingNPC : ExampleNPC
{


    protected override void NodeCreate()
    {
        startNode = new Node("We are the Royal Frog King! We preside over the soup swamps of this domain. What do you want, humble goblin?");

        Node comeWithMe = new Node("But, my royal duties! Who would take care of my frog entourage?",startNode);

        startNode.AddOption("Ask if he wants to go on a boat ride", comeWithMe);

        Node soupCurator = new Node("That simpleton? He can hardly tell right from left, let alone Can from Campbell!",comeWithMe);
    }
}
