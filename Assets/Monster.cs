using UnityEngine;
using System.Collections;
using System;

public class Monster:Character

{
   //public  Monster(){ }

    //  public Inventory inventory = new Inventory(10);

    //  public Monster(String name, String charClass, int strength, int dexterity, int endurance, int intelect) : base(name, charClass, strength, dexterity, endurance, intelect)
    //{
    // RandItems();
    //}
    public void levelUp(int level)
    {

        strength = base_strength + (level - 1) * (base_strength / 2);
        endurance = base_endurance + (level - 1) * (base_endurance / 2);
        dexterity = base_dexterity + (level - 1) * (base_dexterity / 2);
        intelect = base_intelect + (level - 1) * (base_intelect / 2);
        calcSecondaryStats();
        this.level = level;

    }

    /* public void RandItems()
     {
         Type type = typeof(Item);
         var classList = Assembly.GetExecutingAssembly().GetTypes().ToList().Where(t => type.IsAssignableFrom(t) && !t.IsAbstract).ToList();
         for (int i = 0; i <.rand.Next(10); i++) //Придумать проверку на выпадение 
             foreach (var item in classList)
                 if (20 > Util.rand.Next(100))
                     inventory.items.Add((Item)Activator.CreateInstance(item, level)); //Сделать динамический шанс выпадения

     }*/



    // Use this for initialization


    // Update is called once per frame
    void OnGUI()
    {
        // Make a background box
        GUI.Box(new Rect(10, 50, 120, 20), hp.ToString()+" / "+ hpMax.ToString());

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed

    }

}

