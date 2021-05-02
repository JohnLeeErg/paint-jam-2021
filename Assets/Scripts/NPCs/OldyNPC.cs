using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Why hello there young fella! What can old Gimby do for you?");

        startNode.AddOption("\"Sorry, I gotta leave.\"");
    }

}
