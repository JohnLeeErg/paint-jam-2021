using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestlessWandererNPC : ExampleNPC
{
    

    protected override void NodeCreate()
    {
        startNode = new Node("All my days I wander.... I just wish to know, what is out there,, in this world of soup...!");

        Node offerToTakeHimWith = new Node("You would do that for me?? oh joy, i cant wait! pack your bags we're goin to sail the seven soups by george! Lets leave right away.", startNode);

        startNode.AddOption("Offer to take him to your boat", offerToTakeHimWith);

        Node enquireAboutStuff = new Node("I have seen everything there is to see on this little island. The swamp frogs, the riddle master, the soup verifyier, Andy Warhol... ", startNode);

        startNode.AddOption("Ask what he has seen in his wanderings", enquireAboutStuff);

        Node askAboutRiddleMaster = new Node("The riddle master, ah yes, we often partake in a duel of wits, them and I. And though I can often guess at their preliminary ridules, the final question always eludes me...",enquireAboutStuff);

        Node askAboutSoupVerifyier = new Node("I daren't trust that soup verifier, his shifty eyes, his cold stance. But then,  how will I know true soup from the false?", enquireAboutStuff);

        Node askAboutOtherIslands = new Node("Ah, alas, i have heard many fanciful tales, but i have heard not of other lands, for I hath no boat", enquireAboutStuff);

        enquireAboutStuff.AddOption("Ask about the Riddle Master", askAboutRiddleMaster);
        enquireAboutStuff.AddOption("Ask about the Soup Veifyier", askAboutSoupVerifyier);
        enquireAboutStuff.AddOption("Ask about other islands", askAboutOtherIslands);

        offerToTakeHimWith.AddOption("Take Him To The Boat",transform);
        startNode.AddOption("Leave Conversation");
    }
}
