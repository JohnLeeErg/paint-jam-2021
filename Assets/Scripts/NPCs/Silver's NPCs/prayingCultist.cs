using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prayingCultist : ExampleNPC
{
    protected override void NodeCreate()
    {
        startNode = new Node("We pray to our god CampBells Tomato Soup, and his first two messiahs, <color=#7ee7f7>Andy Worhol</color> and <color=#7ee7f7>Paris International</color>. ");

        //option what
        Node option1 = new Node("Now to begin the ceremonial prayer.");

        startNode.AddOption("Ummm?", option1);
        startNode.AddOption("Hello?", option1);
        startNode.AddOption("What are you doing?", option1);

        startNode.AddOption("Leave Conversation");



        Node option2 = new Node("BETA CAROTENE, is found in carrots, sweet potatoes and pumpkins and gives the orange color.");

        option1.AddOption("Can you hear me?", option2);
        option1.AddOption("Are you listening?", option2);
        option1.AddOption("Is this a song?", option2);
        option1.AddOption("Leave Conversation");


        Node option3 = new Node("CANOLA AND SOYBEAN, Vegetable oil.");
        option2.AddOption("What is BETA CAROTENE?", option3);
        option2.AddOption("Who are you?", option3);
        option2.AddOption("Whats Going on here??", option3);
        option2.AddOption("Leave Conversation");

        Node option4 = new Node("CARAMEL COLOUR, food colour made by heating sugar and adds to the flavour.");
        option3.AddOption("Am i bothering you?", option4);
        option3.AddOption("What do you want?", option4);
        option3.AddOption("Leave Conversation");

        Node option5 = new Node("CARRAGEENAN, used as a thickener to keep our chicken meat juicy.");
        option4.AddOption("How long is this?", option5);
        option4.AddOption("CARRAGEENAN? Is that real", option5);
        option4.AddOption("Leave Conversation");

        Node option6 = new Node("CHICKEN STOCK,made from cooking chicken meat and chicken bones in water and then concentrating.");
        option5.AddOption("...", option6);
        option5.AddOption("Leave Conversation");


        Node option7 = new Node("CITRIC ACID, used to control the acidity, derived from either sugar beet or corn through fermentation.");
        option6.AddOption("...", option7);
        option6.AddOption("Leave Conversation");

        Node option8 = new Node("CORN STARCH OR POTATO STARCH, helps to thicken soups and give a consistent texture.");
        option7.AddOption("...", option8);
        option7.AddOption("Leave Conversation");
        Node option9 = new Node("CORN SYRUP SOLIDS, a sweetener made from corn.");
        option8.AddOption("...", option9);
        option8.AddOption("Leave Conversation");
        Node option10 = new Node("CREAM, used for its flavour and to give smooth texture.");
        option9.AddOption("...", option10);
        option9.AddOption("Leave Conversation");
        Node option11 = new Node("DEHYDRATED GARLIC, used to for its flavour.");
        option10.AddOption("...", option11);
        option10.AddOption("Leave Conversation");
        Node option12 = new Node("DEHYDRATED ONIONS, used as a base flavour.");
        option11.AddOption("...", option12);
        option11.AddOption("Leave Conversation");
        Node option13 = new Node("DEXTROSE, a sugar found naturally in fruits and honey");
        option12.AddOption("...", option13);
        option12.AddOption("Leave Conversation");
        Node option14= new Node("EGG NOODLES,  enriched with five essential nutrients and made with flour milled from a mix of durum and spring wheat");
        option13.AddOption("...", option14);
        option13.AddOption("Leave Conversation");
        Node option15= new Node("GLUTAMIC ACID, an amino acid found in animals and plants such as tomatoes and mushrooms.");
        option15.AddOption("Carry cultist to boat", transform);
        option14.AddOption("...", option15);
        option14.AddOption("Leave Conversation");
        option15.AddOption("...", option6);
        option15.AddOption("Leave Conversation");




    }
}
