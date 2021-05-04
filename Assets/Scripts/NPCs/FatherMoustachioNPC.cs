using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherMoustachioNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Well, howdy there fella! How's it goin'? How about that weather? Lookin' like a real scorcher today! But that soup's gonna be comin' down hard tomorrow!");

        /* End nodes
         * 
         * 
         */
        // Abject failure
        Node failAttempt = new Node("Ahh, no thanks fella! I shouldn't be goin on any boat rides today, I gotta catch the game tonight!", startNode);

        // Don't like that
        Node dontLike = new Node("I don't like to talk about that.", startNode);

        // Stand up fella
        Node standUpFella = new Node("Hey, y'know what? You seem like a real stand-up fella. Why don't we get outta here and get a can or two before the game?");

        // Leaving
        Node leaving = new Node("Sounds great, fella! We can take a boat ride, get a couple canskies for the game!");
        leaving.AddOption("[Take him to the boat]", transform);

        // Rejected
        Node rejected = new Node("Ah, ok...");
        rejected.AddOption("[Leave conversation]");

        // Ladler's fan
        Node ladlersFan = new Node("A Ladler's fan??? Pfft, ok fella. Well, I hope you're ready to get beat at the Big Game tonight!");
        ladlersFan.AddOption("[Leave conversation]");


        standUpFella.AddOption("Let's take a boat ride, get a couple canskies for the game!", leaving);
        standUpFella.AddOption("Nah, I'm alright. Maybe another time...", rejected);



        // Weather
        Node weather2 = new Node("BAAAAAHAHAAHA!!!! I wish, friend! It's sure lookin' mighty gorgeous today. Say, that weather's changing all the time these days! One day soup's pourin' down, the next day I'm dry as a raisin!", startNode);
        weather2.AddOption("Yeah, that climate change is a real killer!", dontLike);
        weather2.AddOption("Soup sure is unpredictable. Maybe we need to appease it...", dontLike);
        weather2.AddOption("One day I'm dry as a salteen, the next I'm like a salteen, IN THE SOUP!", standUpFella);

        Node weather = new Node("Ah, that weather's sure lookin' lovely today, ain't it? Looks like soupfall in the forecast tomorrow though!", startNode);
        weather.AddOption("Clear days are great for folks like me! Helps with all the soup-sailing!", dontLike);
        weather.AddOption("Did you order this beautiful weather?", weather2);
        weather.AddOption("Ah, soupfall? I was hoping for another beautiful day like this one!", weather2);



        // Sports
        Node brothsFan = new Node("Aha, I know a Broths fan when I see one! You've got good taste fella! Are ya gonna be watchin' the game tonight?", startNode);
        brothsFan.AddOption("Yeah, I NEVER miss a game!", standUpFella);
        brothsFan.AddOption("Nah, I'm a fan but I probably won't be watching tonight...", rejected);

        Node sports = new Node("Haha! I knew you were a sporty kinda fella! I'm out here gettin' ready for the Big Game tonight! So, are you a Ladlers fan? Or are you rootin' for those Soupland Broths?", startNode);
        sports.AddOption("Saltfield Ladlers", ladlersFan);
        sports.AddOption("Soupland Broths", brothsFan);

        /* Start Node options
         * 
         * 
         */
        startNode.AddOption("Ask if he wants to go on a boat ride", failAttempt);
        startNode.AddOption("How about that weather?", weather);
        startNode.AddOption("How about those sports?", sports);
        startNode.AddOption("How about that family?", dontLike);
        startNode.AddOption("How about those current events?", dontLike);
        startNode.AddOption("[Leave Conversation]");
    }
}
