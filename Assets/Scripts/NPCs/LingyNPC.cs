using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LingyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Oh- Hey- Whatsup? Long time no see...");
        Node greet = new Node("Oh- Pretty good. Just hanging out, you know.", startNode);
        Node farm = new Node("Nah, never did... I had the time, but you know... never quite got around to it.", greet);
        Node doing = new Node("Well, just feeling out the waters. Most of the others our age have left like you did.", farm);
        Node boat = new Node("Oh, really? Awesome! What are we going to do on your boat?", doing);
        Node sacrifice = new Node("Uhhh, on second thought I think I'll pass... See you around.");
        Node purpose = new Node("Wow, really? I can't wait!");

        startNode.AddOption("Oh, Lingy? How've you been?", greet);
        startNode.AddOption("Sorry, I gotta split. [Leave Conversation]");

        greet.AddOption("So, did you ever get that berry farm going?", farm);
        farm.AddOption("So what are you up to now then?", doing);

        doing.AddOption("Well if you arent doing anything else, you should come with me on my boat.", boat);
        doing.AddOption("You'll figure something out eventually, good luck! [Leave Conversation]");

        boat.AddOption("I'm going to <color=#F00000>sacrifice</color> you to <color=#8B0000>The Maw</color> in the center of our world.", sacrifice);
        boat.AddOption("We're going to find you a purpose.",purpose);

        purpose.AddOption("Awesome, lets go then. [Take Lingy to the boat]", transform);

        sacrifice.AddOption("Your loss. See ya. [Leave Conversation]");

    }

}
