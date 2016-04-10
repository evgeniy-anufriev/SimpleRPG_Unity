using UnityEngine;
using System.Collections;
using System;

public class HealthBar : MonoBehaviour {

  

    // Use this for initialization
    void Start () {

        GameObject gameHero = GameObject.FindGameObjectWithTag("Player");
        Hero hero = gameHero.GetComponent<Hero>();
        hero.Character_init(Menu.hero.name, Menu.hero.charClass, Menu.hero.strength, Menu.hero.dexterity, Menu.hero.endurance, Menu.hero.intelect);
        hero.calcSecondaryStats();

        GameObject gameEnemy = GameObject.FindGameObjectWithTag("Enemy");
        Monster enemy = gameEnemy.GetComponent<Monster>();
        enemy.Character_init("ОРК", "Warior", 7, 2, 3, 0);
        enemy.calcSecondaryStats();


    }
	
	// Update is called once per frame
	void Update () {
	
	}

   
}
