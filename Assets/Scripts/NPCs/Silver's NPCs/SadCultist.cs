using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadCultist : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("[Sniffs and wipes away tears] Can you leave me alone?");

        //option what
        Node option1 = new Node("Did you not hear what I asked?", startNode);
        option1.AddOption("No.", startNode);

        Node option1sub1 = new Node("Unsolicited help is no help at all..."); 
        option1.AddOption("I want to help.", option1sub1);

        option1sub1.AddOption("I guess I'll leave then. [Leave Conversation]");

        option1.AddOption("Can you repeat the request?", startNode);
        startNode.AddOption("What happened?", option1);


        Node option2sub1 = new Node("No, I am trapped on this island@");
        startNode.AddOption("Are you ok?", option2sub1);
        Node option2sub11 = new Node("There was one, but my purple college is taking it for his <color=#41F1F4>Journey</color>.");
        option2sub1.AddOption("Are there no boats here?", option2sub11);
        
        Node option2sub111 = new Node("You may find him to the south of hear studying ancient hieroglyphics... He tends to be popular with the tourists.");
        option2sub11.AddOption("Purple colleague?", option2sub111);
        option2sub111.AddOption("[Leave Conversation]");


        Node option2sub112 = new Node("If you're curious, you may ask him. Please do so and leave me alone.");
        option2sub11.AddOption("<color=#41F1F4>Journey</color>?", option2sub112);
        option2sub112.AddOption("[Leave Conversation]");

        Node option2sub113 = new Node("Really? Please take me away from here! Anywhere will do...");
        option2sub11.AddOption("I have a boat.", option2sub113);

        option2sub113.AddOption("[Take him to the boat]",transform);
        option2sub113.AddOption("[Leave Conversation]");


        Node option2sub12 = new Node("My tormentor 'colleague' refuses to let me leave. He often voices his disapproval... With force.", option2sub1);
        option2sub1.AddOption("Is somebody stopping you from leaving?", option2sub12);

        //silent route
        Node option2sub3 = new Node("I came here when my faith in the soup was hot and full. But like every bountiful bowl, it has emptied and grown cold...", startNode);
        Node option2sub32 = new Node("But the rituals demand four believers, one per holy tree! Yet the Soup has never shown that It hears us...", startNode);
        Node option2sub33 = new Node("So here I stay trapped, unless a helpful stranger can do something...?", startNode);
        Node option2sub34 = new Node("...?");
        option2sub1.AddOption("[Stay Silent]", option2sub3);
        option2sub3.AddOption("[Stay Silent]", option2sub32);
        option2sub32.AddOption("[Stay Silent]", option2sub33);
        option2sub33.AddOption("[Stay Silent]", option2sub34);
        option2sub34.AddOption("[Stay Silent]", option2sub34);

        option2sub33.AddOption("I can take you.", transform);
        option2sub34.AddOption("I can take you.", transform);

        option2sub1.AddOption("[Leave Conversation]");
        option2sub3.AddOption("[Leave Conversation]");
        option2sub32.AddOption("[Leave Conversation]");
        option2sub33.AddOption("[Leave Conversation]");
        option2sub34.AddOption("[Leave Conversation]");



        startNode.AddOption("Sorry for disturbing you. [Leave Conversation]");
    }
}
