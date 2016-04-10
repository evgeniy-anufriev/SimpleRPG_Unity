using UnityEngine;
using System.Collections;

public class EnemyAtack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.F))
        {

            GameObject gameHero = GameObject.FindGameObjectWithTag("Player");
            Hero hero = gameHero.GetComponent<Hero>();


            GameObject gameEnemy = GameObject.FindGameObjectWithTag("Enemy");
            Monster enemy = gameEnemy.GetComponent<Monster>();

            hero.getDamage(enemy.makeAttack());
        }

    }
}
