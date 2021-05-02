using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMoustachioNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Hey, greenleather! Whatcha lookin at?");

        /* End nodes
         * 
         * 
         */
        // Abject failure
        Node failAttempt = new Node("Pfft, no thanks. Why don't you go ask blockhead over there?", startNode);

        // Rejection
        Node dismissal = new Node("Yeah, whatever...");
        dismissal.AddOption("[Leave Conversation]");

        // Disbelief
        Node disbelief = new Node("Haha! Yeah right, dumpysnort!");
        disbelief.AddOption("[Leave Conversation]");

        // Defense
        Node defense = new Node("As if I'd tell you!");
        defense.AddOption("[Leave Conversation]");

        // Broken
        Node broken = new Node("[They're sobbing uncontrollably. Inconsolably. Maybe you shouldn't have been so hard on the kid...]");
        broken.AddOption("[Leave Conversation]", "bulliedBaby");




        /* Aggressive path
         * 
         * 
         */
        Node aggressive = new Node("Yeah, greenleather! Cause you're green and ya stink like tannin' leather!", startNode);

        // Aggressive success
        Node aggressiveSuccess = new Node("What??!!?! [They start visibly tearing up]");

        // Roasts
        aggressive.AddOption("Well at least I'm not a silly poo poo diaperhead!", dismissal);
        aggressive.AddOption("Well at least I'm not a stinky dumb dumb little baby pants!", aggressiveSuccess);
        aggressive.AddOption("Oh yeah? Did you practice that one starin' at the soup this morning?", disbelief);
        aggressive.AddOption("Bet you wouldn't say that if you knew who I was...", disbelief);
        aggressive.AddOption("Why are you so mean all the time, little dude?", defense);

        // Double down
        aggressiveSuccess.AddOption("I SAID: AT LEAST I'M NOT A STINKY DUMB DUMB LITTLE BABY PANTS!!!!!!", broken);
        aggressiveSuccess.AddOption("Nothing... Sorry, I don't know what came over me.", dismissal);



        /* Kind Path
         * 
         * 
         */




        /* Start Node options
         * 
         * 
         */
        startNode.AddOption("Ask if they want to go on a boat ride", failAttempt);
        startNode.AddOption("Greenleather? Why you little...", aggressive);
        startNode.AddOption("Whatcha doin' there kiddo?");
        startNode.AddOption("[Leave Conversation]");





        
        
        



        /*
        Node yesIllDoIt = new Node("I do grow weary; the weight of responsibility... Very well, a break couldn't hurt. I will leave my frogs in Valerie's care and come with you!");
        
        yesIllDoIt.AddOption("Take the frog to the boat",transform);
        */
    }

    internal void RefreshNodes()
    {
        throw new NotImplementedException();
    }
}
