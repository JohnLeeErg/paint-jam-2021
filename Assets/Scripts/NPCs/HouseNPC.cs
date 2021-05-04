using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("You there! Knocking on my door! I know what you're here for!!");
        Node lie = new Node("I'm not falling for that one!", startNode);
        Node truth = new Node("Well why don't you do it then!", startNode);
        Node ask = new Node("Well I'm asking \"of you\" to leave!", truth);

        startNode.AddOption("Please! Someone needs to be the one to make the <color=#F00000>Sacrifice</color>.", truth);
        startNode.AddOption("I just want to talk about our Lord and Savoury.", lie);

        truth.AddOption("Huh, good point. Maybe I will. [Leave Conversation]");
        truth.AddOption("That was not what was asked of me.", ask);

        ask.AddOption("Fine, avoid your sacred duty. [Leave Conversation]");
        ask.AddOption("Well, if its not you, it'll be someone else. [Leave Conversation]");

        startNode.AddOption("Alright, I'm leaving now. [Leave Conversation]");
        lie.AddOption("Alright, I'm leaving then. [Leave Conversation]");
    }

}
