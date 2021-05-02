using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MamaMoustachioNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("...");

        // Chosen
        Node chosen = new Node("Fine. I hope I taste like rot.");
        chosen.AddOption("[Take her to the boat]", transform);

        // No
        Node no = new Node("No...");
        no.AddOption("[Leave Conversation]");

        // Yeah
        Node yeah = new Node("Yeah.");
        yeah.AddOption("[Leave Conversation]");

        // In this way
        Node inThisWay = new Node("In a way that it makes it hard to talk about it with suspicious strangers.");
        inThisWay.AddOption("[Leave Conversation]");

        // In a way
        Node inAWay = new Node("In a way, yes...");
        inAWay.AddOption("In what way?", inThisWay);

        // You dont get it
        Node dontGetIt = new Node("You don't get it");
        dontGetIt.AddOption("[Leave Conversation]");

        // I hope that makes you feel better
        Node feelBetter = new Node("I hope that makes you feel better.");
        feelBetter.AddOption("[Leave Conversation]");

        // Could be worse?
        Node couldBeWorse = new Node("And what of the children? Are they to waste away on this tiny island forever too? To fight over garbage until The Maw decides it's their time? I know who you are, Goblin. If you're here to take me away, do it. But leave the children alone.");
        couldBeWorse.AddOption("You have been chosen. Please, come with me.", chosen);
        couldBeWorse.AddOption("What am I supposed to do? If I don't take one of you, The Maw will take me!", feelBetter);
        couldBeWorse.AddOption("...", yeah);

        // Have you talked to the man?
        Node haveYouTalked = new Node("Have you talked to the man? All he cares about is SPORTS and the WEATHER. Can he not see where we are? Does he not care that we live meaningless lives, floating in this soup sea, with nothing to do but watch the Big Game and wait for some wretched soup goblin to come take us away?");
        haveYouTalked.AddOption("I mean, it could be worse...", couldBeWorse);



        // Father
        Node father = new Node("... [She glances over at Father Moustachio, who's busy happily bouncing back and forth in a sports-and-weather-based reverie] Yes.");
        father.AddOption("Why? What's so bad about him?", haveYouTalked);
        father.AddOption("Yeah. He's a bit of a goof.", dontGetIt);



        // Thinking
        Node thinking = new Node("I come out here to think sometimes... To the rocks. To get away from...");
        thinking.AddOption("The kids?", no);
        thinking.AddOption("Baby Moustachio?", no);
        thinking.AddOption("Moustache Kid?", no);
        thinking.AddOption("Father Moustachio?", father);
        thinking.AddOption("Everything?", inAWay);

        // Initial
        Node what = new Node("... What do you want?");
        what.AddOption("Ask if she want to go on a boat ride", no);
        what.AddOption("What are you doing over here?", thinking);


        startNode.AddOption("Hello?", what);
        startNode.AddOption("[Leave Conversation]");
    }
}
