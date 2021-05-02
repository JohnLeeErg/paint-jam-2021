using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldyNPC : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("Why hello there young fella! What can old Gimby do for you?");
        Node back = new Node("Nah, I've been on this island a long time, I always know who'll come back.", startNode);
        Node island = new Node("Yep, I couldn't imagine living anywhere else.", back);

        Node gobbos = new Node("I sure have! Used to be more help though, back when my bones weren't so creaky... When I could still chop down trees and build ships.", back);

        Node help = new Node("Really, how would I do that?", gobbos);

        Node boat = new Node("Well, if you say so, I'll follow you then.");

        Node spirit = new Node("Ahahaha, I suppose you're right...", gobbos);

        Node old = new Node("Well I ain't young, but you don't have to go pointing it out all the time!");
        Node die = new Node("Why I never... *grumbles* You know... You never can say what life has in store for you.", old);
        Node sacrifice = new Node("What! I ain't dead yet sonny jim! Get out of here with that nonsense!");

        startNode.AddOption("\"Aren't you suprised to see me back Gimby?\"", back);

        back.AddOption("\"You sure have helped a lot of young Gobbos over the years\"", gobbos);
        back.AddOption("\"Well it's good to be back, I sure missed this island.\"", island);

        gobbos.AddOption("\"Phooey, you still got the spirit in you, and thats what counts!\"", spirit);
        gobbos.AddOption("\"Say, I know a way you could still be a big help, creaky bones and all...\"", help);

        help.AddOption("\"Just come with me on my boat, and I'll show you...\"", boat);

        boat.AddOption("\"Lets go then.\"", transform);
        boat.AddOption("\"Actually, you might be a better help around here, I'll see you later.\"");

        island.AddOption("\"You said it pops, I'm gonna go look around, catch ya later\"");

        spirit.AddOption("\"Well, I'll see you later, bye!\"");

        startNode.AddOption("\"Soo... You're old right?\"", old);

        old.AddOption("\"Sorry, that was rude, lets talk about something else.\"", startNode);
        old.AddOption("\"I just mean, you're gonna die soon right?\"", die);

        die.AddOption("\"You should let me sacrfice you to the soup gods, or something.\"", sacrifice);

        sacrifice.AddOption("\"Sorry I asked, see you around.\"");

        startNode.AddOption("\"Sorry, I gotta leave.\"");
    }

}
