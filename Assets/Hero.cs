using UnityEngine;
using System.Collections;
using System;

public class Hero : Character {
   //public  Hero(){ }
    
        //public Inventory inventory;
       // public Hero(String name, String charClass, int strength, int dexterity, int endurance, int intelect) : base(name, charClass, strength, dexterity, endurance, intelect)
       // {
            // inventory = new Inventory();
       // }

    void OnGUI()
    {
        // Make a background box
        GUI.Box(new Rect(10, 10, 120, 20), hp.ToString() + " / " + hpMax.ToString()); 

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed

    }
}
 
