using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupInspectorNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Ew! What do you want, little soup goblin? I'm busy verifying the inegrity of these Campbells cans, for I am He, the Soup Verifier!");

        Node whereSoupComesFrom = new Node("Ha! A Novice question! Soup emerges from the Maw of course, in cannisters, in Noble Contridiction to the ebb of Open Soup Ocean Flows. In time the cannisters reach shore and are cracked open and the soup drains back into The Maw, as it has always been, dumbo!",startNode);

        startNode.AddOption("Where do the soup cans come from?",whereSoupComesFrom);

        Node visitIt = new Node("Visit The Maw! Strictly forbidden! Although.... To glimpse it just once,.. It's a soup verifyier's dream...");

        whereSoupComesFrom.AddOption("tell him you can take him to The Maw",visitIt);

        Node arentCampbellsCansAllTheSame = new Node("Nothing could be further from the truth! A descerning eye will know that there are many flavours, with subtly distinct packaging. It's important to be able to tell the real thing from a mere Andy painting after all.", startNode);

        startNode.AddOption("ask why you need a 'Soup Verifier', aren't all Campbells cans identical?", arentCampbellsCansAllTheSame);

        Node furtherQuestion = new Node("Prying aren't we! Who put you up to this? was it James? That redneck turncoat will get us both in trouble. You soup goblins don't know how good you've got it. Get out of here!");

        arentCampbellsCansAllTheSame.AddOption("Ask who he is even verifying these cans for", furtherQuestion);

        Node cmonnnn = new Node("Alright, alright, lets do it! Just a peak, though, and then I have to get back to work.");

        visitIt.AddOption("say 'cmonnnnn doo itttt'", cmonnnn);

        startNode.AddOption("Leave Conversation");
    }
}
