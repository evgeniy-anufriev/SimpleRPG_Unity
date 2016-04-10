using UnityEngine;
using System.Collections;

public class PlayerAtack : MonoBehaviour {
  
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        /*if (Input.GetKeyUp(KeyCode.F))
        {

            GameObject gameHero = GameObject.FindGameObjectWithTag("Player");
            Hero hero = gameHero.GetComponent<Hero>();


            GameObject gameEnemy = GameObject.FindGameObjectWithTag("Enemy");
            Monster enemy = gameEnemy.GetComponent<Monster>();

            enemy.getDamage(hero.makeAttack());
             */
    }


   /* private void OnTriggerEnter(Collider collider)
    {
        Character hitObject = collider.gameObject.GetComponent<Character>();
        Character ddObject = gameObject.GetComponent<Character>();

        hitObject.getDamage(ddObject.makeAttack());
    }*/

    private void OnCollisionEnter(Collision collider)
    {
        Character hitObject = collider.gameObject.GetComponent<Character>();
        Character ddObject = gameObject.GetComponent<Character>();

        hitObject.getDamage(ddObject.makeAttack());
    }
}
 
