using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoustacheKidNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Um... Hi there! [Wipes away tears and smiles]");

        // Abject failure
        Node failAttempt = new Node("Um... N-no thanks... I'm not supposed to leave here with strangers!", startNode);

        // Defeat
        Node defeat = new Node("...");
        defeat.AddOption("[Leave Conversation]");


        // Help path
        Node wrong = new Node("Oh, nothing... I don't wanna talk about it. [Tears start welling up again] B-baby Moustachio says everybody h-hates a tattle-tale.", startNode);
        Node help = new Node("Well... If you really just want to help... Baby Moustachio stole my special can! [Sniffs and wipes tears] It's my favorite thing in the whole wide world and he just took it! I'll never find another one...");


        wrong.AddOption("Hey now! Nobody says you're a tattle-tale! Don't worry, I just want to help.", help);
        wrong.AddOption("Yep, they're right about that. Everybody hates a little poo poo tattle-tale!", defeat);

        help.AddOption("Hmm... Maybe I can help you get that can back...");
        help.AddOption("Well, looks like you're shit outta luck, kid.", defeat);


        startNode.AddOption("Ask if they want to go on a boat ride", failAttempt);
        startNode.AddOption("Hey, what's wrong?", wrong);
        startNode.AddOption("[Leave Conversation]");
    }
}
