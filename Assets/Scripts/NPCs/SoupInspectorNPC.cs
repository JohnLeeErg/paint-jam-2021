using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupInspectorNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Ew! What do you want, little <color=#5DA45D>Soup Goblin</color>? I'm busy verifying the integrity of these Campbells Cannisters... For I am He, the Soup Verifier!");

        Node whereSoupComesFrom = new Node("Ha! A Novice question! Soup emerges from <color=#8B0000>The Maw</color> of course, in Cannisters, in Noble Contradiction to the ebb of Open Soup Ocean Flows. In time the Cannisters reach shore and are cracked open. The soup then drains back into <color=#8B0000>The Maw</color> fulfilling the Eternal Cycle. This is how it has always been, dumbo!", startNode);

        startNode.AddOption("Where do the soup cans come from?",whereSoupComesFrom);

        Node visitIt = new Node("Visit <color=#8B0000>The Maw</color>! Strictly forbidden! Although... To glimpse it just once... It's a soup verifier's dream...", whereSoupComesFrom);

        whereSoupComesFrom.AddOption("[Tell him you can take him to <color=#8B0000>The Maw</color>]", visitIt);

        Node arentCampbellsCansAllTheSame = new Node("Nothing could be further from the truth! A descerning eye will know that there are many flavours, with subtly distinct packaging. It's important to be able to tell the real thing from a mere Andy Warhol painting after all.", startNode);

        startNode.AddOption("Why do we need a 'Soup Verifier'? Aren't all Campbells cans identical?", arentCampbellsCansAllTheSame);

        Node furtherQuestion = new Node("Prying, aren't we? Who put you up to this? Was it James? That redneck turncoat will get us both in trouble. You <color=#5DA45D>Soup Goblins</color> don't know how good you've got it. Get out of here!");

        arentCampbellsCansAllTheSame.AddOption("Who are you even verifying these cans for?", furtherQuestion);

        Node cmonnnn = new Node("Alright, alright, lets do it! Just a peek, though, and then I have to get back to work.");
        cmonnnn.AddOption("[Take him to the boat]", transform);
        cmonnnn.AddOption("[Leave the Soup Verifier to his soups]");

        visitIt.AddOption("Cmonnnnn, just doooooooo itttt!", cmonnnn);
        furtherQuestion.AddOption("[Leave Conversation]");
        startNode.AddOption("[Leave Conversation]");
    }
}
