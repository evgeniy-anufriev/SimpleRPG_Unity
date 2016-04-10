using UnityEngine;
using System.Reflection;
using System;
using System.Collections.Generic;

public class TestFight : MonoBehaviour {
    public static System.Random rand = new System.Random();
    void Start () {
        //Hero hero = gameHero.GetComponent<Hero>();
    }

    // Update is called once per frame
    void Update()
    {

          if (Input.GetKeyUp(KeyCode.F))
          {
  
            GameObject gameHero = GameObject.FindGameObjectWithTag("Player");
             Hero hero = gameHero.GetComponent<Hero>();
             

             GameObject gameEnemy = GameObject.FindGameObjectWithTag("Enemy");
             Monster enemy = gameEnemy.GetComponent<Monster>();

                enemy.getDamage(hero.makeAttack());
                hero.getDamage(enemy.makeAttack());

        }
     
    }


    private void OnTriggerEnter(Collider collider)
    {

    }
}
