using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purpleCultist : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("These inscriptions.... I have spent all my life trying to uncover their meaning, yet I am no closer to finding out what they mean....");

        //option what
        Node option1 = new Node("I think it <color=#7ee7f7>MUST</color>relate to capturing the legendary <color=#7ee7f7>WT</color> sea mosnter. " +
            "The <color=#7ee7f7>10 3/4 OZ (305G)</color> might be coordanintes to its lair. I will soon embark on a journay to other islands to find more hints", startNode);
        startNode.AddOption("What do you think it means?", option1);
        
        //you are right
        //you are wrong


        //option why
        Node option2 = new Node("Prophecy fortells of the <color=#7ee7f7>soup Hero</color> who will come and using these symbols find a way to stop the great rottening", startNode);
        startNode.AddOption("Why are you deciphering them", option2);

        Node sub1option2 = new Node("No, but I dreamed I was once...", startNode);
        option2.AddOption("Are you the <color=#7ee7f7>Hero</color>", sub1option2);

        Node sub3option2 = new Node("Really? lead the way", startNode);
        option2.AddOption("I can take you to someone who knows", sub3option2);

        //option i know
        Node option3 = new Node("Really? You know easily after I have dedicated a lifetime studying these hieroglyphics? do tell...", startNode);
        startNode.AddOption("I know what they mean", option2);

        Node sub3Option1 = new Node("like it would describe that! to think you take me for a fool!", startNode);
        option3.AddOption("it describe net weight", sub3Option1);
        option3.AddOption("it describe the weight in grams", sub3Option1);
        option3.AddOption("it describe the weight in ounces", sub3Option1);

        startNode.AddOption("Leave Conversation");

        sub1option2.AddOption("Leave Conversation");
    }
}
