using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Hi....          Um...         What's your deal?");

        Node whatAreYouDoing = new Node("I'm thinking about...          Painting a can of Campbells Soup...      Maybe a lot of them...", startNode);

        Node whatsTheMeaning = new Node("Um,      I dont... know?    I don't think I should just tell you what it means...     You've gotta feel it, right? OK...",startNode);

        Node notReally = new Node("Uh....          No not right now...       Sorry.. ",startNode);

        whatAreYouDoing.AddOption("What does that mean?", whatsTheMeaning);
        startNode.AddOption("What's my deal?           What's your deal?!", whatAreYouDoing);

        startNode.AddOption("You should come on my boat so you can <color=#F00000>sacrifice</color> yourself to <color=#8B0000>The Maw</color>.", notReally);


        startNode.AddOption("You should come on my boat so we can hang out!", notReally);


        startNode.AddOption("You should come on my boat so we can travel the world!", notReally);

        Node art = new Node("Oh..       Yeah, that would be kinda cool but..      What do we do with it, y'know?    What would it             do?", startNode);

        art.AddOption("It would move people to make a change in their lives!", notReally);

        art.AddOption("It would be an art statement against art, abstract and impenetrable!", notReally);

        art.AddOption("It would be really hot, like it would be a sexy move, to come on the boat with me.", notReally);

        Node money = new Node("Yeah OK....          Yeah that seems pretty good,            art            lets go!", art);

        art.AddOption("It would make a ton of money.", money);



        money.AddOption("[Leave Andy to his cans]");

        money.AddOption("[Take Andy out to sea]", transform);

        startNode.AddOption("You should come on my boat, 'cause it would be like, an art... statement", art);

        startNode.AddOption("[Leave Andy to his cans]");

    }
}
