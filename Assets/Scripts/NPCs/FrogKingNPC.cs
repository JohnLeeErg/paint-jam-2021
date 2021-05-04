using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogKingNPC : ExampleNPC
{


    protected override void NodeCreate()
    {
        startNode = new Node("We are the Royal Frog King! We preside over the Soup Swamps of this domain. What do you want, humble <color=#5DA45D>Soup Goblin</color>?");

        Node comeWithMe = new Node("But, my royal duties! Who would take care of my frog entourage?",startNode);

        startNode.AddOption("[Ask if he wants to go on a boat ride]", comeWithMe);

        Node soupCurator = new Node("That simpleton? He can hardly tell right from left, let alone Can from Campbell!", comeWithMe);

        Node andyWarhol = new Node("I don't think that would be a good idea. He's too focused on his can-terfitting; he wouldn't be able to give my kin the attention they deserve.", comeWithMe);

        Node valery = new Node("Now there's an idea! She's really the only person on this island with the force of will to get these frogs into line. I suppose I could leave them with her.",comeWithMe);

        Node riddleMaster = new Node("Jimmy? I couldn't ask him to do that. His role in this island's ecosystem is vital. It would crumble without his focused meditation and riddle-giving.", comeWithMe);

        Node theWanderer = new Node("Harold? I fear he would lose track of my precious frogs on his incessant meanderings. That boy's head is in the clouds, instead of in the Soup where it ought to be.", comeWithMe);

        comeWithMe.AddOption("Let the Soup Verifier take care of them.", soupCurator);
        comeWithMe.AddOption("Let Valery take care of them.", valery);
        comeWithMe.AddOption("Let Andy Warhol take care of them.", andyWarhol);
        comeWithMe.AddOption("Let the Riddle Master take care of them.", riddleMaster);
        comeWithMe.AddOption("Let that wandering little guy take care of them.", theWanderer);

        Node yesIllDoIt = new Node("I do grow weary; the weight of the crown lies heavy upon me... Very well, a break couldn't hurt. I will leave my frogs in Valerie's care and come with you!");
        valery.AddOption("Let's go then!", yesIllDoIt);
        startNode.AddOption("[Leave Conversation]");
        yesIllDoIt.AddOption("[Take the frog to the boat]",transform);
        yesIllDoIt.AddOption("[Leave the frog to his people]");
    }
}
