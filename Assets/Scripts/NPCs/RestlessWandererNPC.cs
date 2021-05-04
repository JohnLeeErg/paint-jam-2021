using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestlessWandererNPC : ExampleNPC
{
    

    protected override void NodeCreate()
    {
        startNode = new Node("All my days I wander.... I just wish to know, what is out there... In this world of soup!");

        Node offerToTakeHimWith = new Node("You would do that for me? Oh joy, I can't wait! Pack your bags, we're goin' to sail the Seven Soups, by George! Let's leave right away!", startNode);

        startNode.AddOption("[Offer to take him to your boat]", offerToTakeHimWith);

        Node enquireAboutStuff = new Node("I have seen everything there is to see on this little island. The swamp frogs, the Riddle Master, the Soup Verifier, Andy Warhol..", startNode);

        startNode.AddOption("[Ask what he has seen in his wanderings]", enquireAboutStuff);

        Node askAboutRiddleMaster = new Node("The Riddle Master... Ah yes, we often partake in a duel of wits, them and I. And though I can often guess at their preliminary ridules, the final question always eludes me...", enquireAboutStuff);

        Node askAboutSoupVerifyier = new Node("I daren't trust that Soup Verifier, his shifty eyes, his cold stance. But then... how will I know the true Soup from the false?", enquireAboutStuff);

        Node askAboutOtherIslands = new Node("Alas, I have heard many fanciful tales, but I have heard not of other lands, for I hath no boat...", enquireAboutStuff);

        enquireAboutStuff.AddOption("[Ask about the Riddle Master]", askAboutRiddleMaster);
        enquireAboutStuff.AddOption("[Ask about the Soup Verifier]", askAboutSoupVerifyier);
        enquireAboutStuff.AddOption("[Ask about other islands]", askAboutOtherIslands);

        offerToTakeHimWith.AddOption("[Take him to the boat]",transform);
        startNode.AddOption("[Leave Conversation]");
    }
}
