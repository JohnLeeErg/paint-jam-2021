using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumbyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Myeh? Hey there.");
        Node greet = new Node("Oh, I was trying to build a boat for a while, but it floated away. *grumbles*", startNode);
        Node sucks = new Node("Damn right it does! It was a huge waste of time if you ask me.", greet);
        Node console = new Node("I suppose you're right. Can't give up now.");
        Node sad = new Node("You bet! I feel like my life's purpose washed out into the soup with that boat.", console);
        Node life = new Node("I suppose you're right... Y'know kid, it feels good to get this stuff off my chest. Thanks for chatting with me.");
        Node death = new Node("You got that right... Sometimes I wish I could just walk out into the soup and die...", sad);
        Node propose = new Node("Really? How?", death);
        Node come = new Node("Wow, and I get to ride on a boat? Sign me up!");

        startNode.AddOption("Hey Jumby, whats up?", greet);
        startNode.AddOption("Sorry, I gotta leave. [Leave Conversation]");

        greet.AddOption("Wow, that sucks big time.", sucks);
        greet.AddOption("Ah well, that's life. Don't let it get you down though", console);

        sucks.AddOption("You're probably really sad now, huh?", sad);
        sucks.AddOption("Yep, too bad. See you around then.");

        sad.AddOption("Well, remember: life goes on.", life);
        sad.AddOption("Honestly, what's even the point in living? One big waste of time.", death);

        life.AddOption("Anytime Jumby. See you around. [Leave Conversation]");

        death.AddOption("Say, there's a way that you could do that while also helping a lot of people.", propose);

        propose.AddOption("Just come with me on my boat and I'll show you...", come);

        come.AddOption("Great, lets go then. [Take Jumby to the boat]", transform);

        console.AddOption("That's right! I'll see you around then. [Leave Conversation]");
    }

}
