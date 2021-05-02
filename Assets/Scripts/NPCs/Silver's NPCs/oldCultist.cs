using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldCultist : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("These inscriptions.... I have spent all my life trying to uncover their meaning, yet I am no closer to finding out what they mean....");

        //option what
        Node option1 = new Node("Ah a soup goblin, I know what your presence here means. I am ready for the journey", startNode);

        Node option1sub1 = new Node("You think you are the first or the last? there has been countless goblins before you.", startNode);
        startNode.AddOption("soup goblins", option1sub1);

        Node option1sub2 = new Node("It is my time. The young are taken to often. This land used to be plentiful with people", startNode);
        startNode.AddOption("ready", option1);

        Node option1sub3 = new Node("The maw always hungers, it might never be satisfied. Hopefully I can sate it long enough for others to live", startNode);
        startNode.AddOption("journey", option1);


        startNode.AddOption("Take the Old Man", transform);


        //not first soup goblin
        startNode.AddOption("Leave Conversation");
    }
}
