using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroolyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Hah, what are you doing in this crap hole?");
        Node greeting = new Node("Yep, souprised to see you back here.", startNode);
        Node maw = new Node("Hah, you should toss the old geezer in. He's not long for this world anyway.", greeting);
        Node job = new Node("Really? Does it pay well?", greeting);
        Node money = new Node("Haha, you should definitely pick me then. I doubt any of these other idiots could do it.");
        Node free = new Node("Yeaahh, I'm gonna have to pass then. You should ask Frooly, that idiot would probably work for free.");

        startNode.AddOption("Oh, it's you.", greeting);
        startNode.AddOption("Sorry, I gotta split.");

        greeting.AddOption("Yep, I came back to find someone to toss into <color=#8B0000>The Maw</color>.", maw);
        greeting.AddOption("Well, I returned to pick someone for a super special job.", job);

        maw.AddOption("Maybe I will. Thanks for the tip... [Leave Conversation]");
        maw.AddOption("You shouldn't be so rude. Bye. [Leave Conversation]");

        job.AddOption("No, you have to want to do out of the the goodness of your heart.", free);
        job.AddOption("Yep, a ton of money. It's a difficult job though.", money);

        money.AddOption("Great, just wait over on my boat then. [Take them to the boat]", transform);
        money.AddOption("I'll have to think about it some more... See you later. [Leave Conversation]");

        free.AddOption("Good idea. Thanks for the tip... [Leave Conversation]");


    }

}

