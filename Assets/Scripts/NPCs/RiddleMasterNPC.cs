using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleMasterNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Howdy Pardner! I'm the Riddle Master! I know what y'all seek. I'll join ya on your <color=#5DA45D>Soup Goblin</color> Pilgrimage... For a price that is! You must first answer my three riddles. Yee Haw!");

        Node FailedRiddle = new Node("Incorrect, Pardner. Better luck next time. So long little doggies. Yippee ki yay!",startNode);

        Node Riddle1 = new Node("Question 1: Which of the following is not a real Campbell's Soup Slogan:", startNode);

        startNode.AddOption("Tell the Riddle Master to 'Bring it on!' ", Riddle1);

        Node Riddle2 = new Node("Question 2: How many wigs is Andy Warhol in posession of?", startNode);

        Node Riddle3 = new Node("And now for y'all's Final Question: What is my full name?", startNode);

        Node Finished = new Node("Hot dawg! You've solved all my riddles n' inquiries! I am at your service, pardner! What do you choose?", startNode);

        

        Riddle1.AddOption("So Many Reasons Its So Mmm Mmm Good", FailedRiddle);
        Riddle1.AddOption("Delicious Soup, In So Many Ways", Riddle2);
        Riddle1.AddOption("Made for real, Real life", FailedRiddle);
        Riddle1.AddOption("Never Underestimate The Power Of Soup!", FailedRiddle);
        Riddle1.AddOption("Soup Is Good Food", FailedRiddle);

        Riddle2.AddOption("Over 40", Riddle3);
        Riddle2.AddOption("Roughly 2 dozen", FailedRiddle);
        Riddle2.AddOption("Hundereds", FailedRiddle);
        Riddle2.AddOption("Over 60", FailedRiddle);
        Riddle2.AddOption("Only 2", FailedRiddle);

        Riddle3.AddOption("Joshua H. Calibash", FailedRiddle);
        Riddle3.AddOption("Harold Leftwise Carpinter", FailedRiddle);
        Riddle3.AddOption("James Whitby Arthurs", Finished);
        Riddle3.AddOption("Andrew B. Hotkins",FailedRiddle);
        Riddle3.AddOption("Casey 'Corksrew' Denson",FailedRiddle);

        Finished.AddOption("[Bring Jimmy the Riddle Master to the boat]",transform);
        Finished.AddOption("[Let Jimmy the Riddle Master remain here]");

        startNode.AddOption("[Give Up] I will never solve these riddles...");
    }
}
