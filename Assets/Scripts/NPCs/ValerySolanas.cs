using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValerySolanas : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("I'm Valery Solanas, who the hell are you?");

        Node whatUpTo = new Node("I'm thinking about how I can best kill this bastard Andy Warhol over here. He's been conspiring against me.",startNode);

        Node whyKillHim = new Node("He has too much control over my life! I needa get him outta the picture so I can publish my book!",whatUpTo);

        Node heardThatOneBefore = new Node("Yeah yeah, I've heard that one before! get lost, chump!", startNode);

        Node hmmWhyNot = new Node("eahhhhhh, ya alright whats the worst that could happen, I get fed to da Maw or somethin? Ha ha! Lets go!");

        Node fackOff = new Node("That depends, do you got a hundred bucks? Ha ha just kidding I know you don't, you're a dirty Soup Goblin. Get the hell outta here!",startNode);

        

        startNode.AddOption("What are you up to?", whatUpTo);

        whatUpTo.AddOption("Ask why she needs to kill him", whyKillHim);

        whyKillHim.AddOption("Why don't I take you to the Maw. Maybe it can help fund your book?", heardThatOneBefore);

        whyKillHim.AddOption("Why don't I take you to the Maw, so that it can help you kill Andy Warhol?", hmmWhyNot);

        Node killHImForMEe = new Node("Yeah, that'd save me a lotta effort thats for sure. Get on it already, chop chop!");

        killHImForMEe.AddOption("Go talk to Andy, I guess");

        whyKillHim.AddOption("Why don't I lure Andy Warhol to the Maw and throw him in?",killHImForMEe);

        hmmWhyNot.AddOption("Take Valery to The Maw");

        hmmWhyNot.AddOption("Leave Valery to her Schemes");

        startNode.AddOption("Wanna come hang out on my cool raft?", fackOff);

        startNode.AddOption("Leave Valery to her Schemes");
    }
}
