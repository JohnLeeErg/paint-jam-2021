using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purpleCultist : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("These inscriptions... I have spent all my life trying to uncover their meaning, yet I am no closer to understanding...");

        //option what
        Node option1 = new Node("I think it <color=#7ee7f7>MUST</color> relates to capturing the legendary <color=#7ee7f7>WT</color> sea monster." +
            "The <color=#7ee7f7>10 3/4 OZ (305G)</color> might be coordinates to its lair. I will soon embark on a journay to other islands to find more clues.", startNode);
        startNode.AddOption("What do you think it means?", option1);

        Node option1Sub4 = new Node("Legends say that at the center of the red sea there lies a creature so unholy it could consume us all!!!", option1);
        option1.AddOption("<color=#7ee7f7>WT</color> sea monster?", option1Sub4);
        


        Node option1Sub5 = new Node("No! I still have so much to live for!!!!");
        option1Sub4.AddOption("Would you like to be taken there?", option1Sub5);
        option1Sub4.AddOption("[Leave Conversation]");
        option1Sub5.AddOption("[Leave Conversation]");
        //you are right
        //you are wrong


        //option why
        Node option2 = new Node("Prophecy foretells of the soup <color=#7ee7f7>Hero</color> who will come and using these symbols find a way to stop the Rottening.", startNode);
        startNode.AddOption("Why are you deciphering them?", option2);

        Node option1Sub2 = new Node("Legend has it that when the preservitives run out of power, the land and Soup itself will Rot with disease, killing us all...",option2);
        option2.AddOption("The Rottening?", option1Sub2);


        Node sub1option2 = new Node("No, but I dreamed I was once...", option2);
        option2.AddOption("Are you the <color=#7ee7f7>Hero</color>?", sub1option2);

        Node sub3option2 = new Node("Really? Lead the way!", startNode);
        option2.AddOption("I can take you to someone who knows...", sub3option2);
        sub3option2.AddOption("[Take them to the boat]", transform);

        //option i know
        Node option3 = new Node("Really? You deciphered it so easily? I have dedicated a lifetime studying these hieroglyphics. Do tell...", startNode);
        startNode.AddOption("I know what they mean.", option3);
        option1.AddOption("I know what it really means...", option3);

        Node sub3Option1 = new Node("Do you take me for a fool?", option3);
        option3.AddOption("It describes net weight.", sub3Option1);
        option3.AddOption("It describes the weight in grams.", sub3Option1);
        option3.AddOption("It describes the weight in ounces.", sub3Option1);

        startNode.AddOption("[Leave Conversation]");

        sub1option2.AddOption("[Leave Conversation]");
    }
}
