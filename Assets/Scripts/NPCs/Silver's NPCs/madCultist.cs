using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class madCultist : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("These inscriptions... I have spent all my life trying to uncover their meaning, yet I am no closer to understanding...");

        //option what
        Node option1 = new Node("I think it <color=#7ee7f7>MUST</color> relate to capturing the legendary <color=#7ee7f7>WT</color> sea monster." +
            "The <color=#7ee7f7>10 3/4 OZ (305G)</color> might be coordinates to its lair. I will soon embark on a journay to other islands to find more clues.", startNode);
        startNode.AddOption("What do you think it means?", option1);


        startNode.AddOption("[Leave Conversation]");
    }
}
