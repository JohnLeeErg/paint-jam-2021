using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Hi....          Um...       What's your deal?");

        Node whatAreYouDoing = new Node("I'm thinking about...        Painting a can of Campbells Soup...      Maybe a lot of them..", startNode);

        Node whatsTheMeaning = new Node("Um,      I dont know?    I don't think I should just tell you what it means...     You've gotta feel it, right? OK... ");

        Node notReally = new Node("Uh....          No not right now...       Sorry.. ",startNode);


        startNode.AddOption("What's my deal? what's your deal!", startNode);

        startNode.AddOption("You should come on my boat so you can sacrifice yourself to the Maw.",notReally);


        startNode.AddOption("You should come on my boat so we can hang out!", notReally);


        startNode.AddOption("You should come on my boat so we can travel the world!", notReally);

        Node art = new Node("Oh..       Yeah that would be kinda cool but..    what we do with it yknow?    what would it             do?", startNode);

        art.AddOption("It would move people to make a change in their lives!", notReally);

        art.AddOption("It would be an art statement against art, abstract and impenetrable!", notReally);

        art.AddOption("It would be really hot, like it would be a sexy move, to come on the boat with me.", notReally);

        Node money = new Node("Yeah ok....          Yeah that seems pretty good,         art          lets go!", art);

        art.AddOption("It would make a ton of money", money);



        money.AddOption("Leave Andy to his Cans");
        money.AddOption("Take Andy out to Sea");

        startNode.AddOption("You should come on my boat, just cause it would be cool, as like an art, like, statement");

    }
}
