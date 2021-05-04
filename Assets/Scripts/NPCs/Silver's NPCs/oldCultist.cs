using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldCultist : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Ahhh, a <color=#5DA45D>Soup Goblin</color>. I know what your presence here means. I am ready for the <color=#41F1F4>Journey</color>.");

        //option what

        Node option1sub1 = new Node("You think you are the first or the last? There have been countless <color=#5DA45D>Goblins</color> before you.", startNode);
        startNode.AddOption("<color=#5DA45D>Soup Goblins</color>?", option1sub1);

        Node option1sub2 = new Node("It is my time. The young are taken too often. This land used to be plentiful with people...", startNode);
        startNode.AddOption("Ready?", option1sub2);

        Node option1sub3 = new Node("<color=#8B0000>The Maw</color> always hungers... With each refilling of the Soup, one must be Chosen to feed it. <color=#8B0000>The Maw</color> might never be satisfied. Hopefully I can at least sate it long enough for others to live.", startNode);
        startNode.AddOption("<color=#41F1F4>The Journey</color>?", option1sub3);


        startNode.AddOption("[Take him to the boat]", transform);


        //not first soup goblin
        startNode.AddOption("[Leave Conversation]");
    }
}
