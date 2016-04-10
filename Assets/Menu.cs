using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
   

    public GUISkin myskin;   //custom GUIskin reference
    public string gameLevel; //level to open on clicking Play button
    public string creditsLevel;  //level to load on click of Credits button    
    float virtualWidth = 960.0f; //width of the device you're using
    float virtualHeight = 540.0f; //height of the device
    public float fontSize = 27; //preferred fontsize for this screen size
    public int value = 20;  //factor value for changing fontsize if needed
    public  int window;
    public static Hero hero=new Hero();
    void Start()
    {
        //check if the size on which game is being played is different
        if (virtualWidth != Screen.width || virtualHeight != Screen.height)
        {
            //set the new screen sizes if different
            virtualWidth = Screen.width;
            virtualHeight = Screen.height;
            //screen size dependent font size calculation
            fontSize = Mathf.Min(Screen.width, Screen.height) / value;
        }
    }
    private void OnGUI()
    {
        GUI.skin = myskin;   //use the custom GUISkin
        myskin.button.fontSize = (int)fontSize; //set the fontsize of the button 
        myskin.box.fontSize = (int)fontSize; //set the font size of box

        //create a menu
        if (window == 0)
        {
            GUI.Box(new Rect(Screen.width / 8, 10, 3 * Screen.width / 4, 3 * Screen.height / 4), "MAIN MENU"); //a box to hold all the buttons

            if (GUI.Button(new Rect(Screen.width / 8, Screen.height / 8 + 10, 3 * Screen.width / 4, Screen.height / 8), "PLAY"))
            {
                window++;
                UnityEngine.SceneManagement.SceneManager.LoadScene(2); //open the game scene
            }


            if (GUI.Button(new Rect(Screen.width / 8, 3 * Screen.height / 8 + 10, 3 * Screen.width / 4, Screen.height / 8), "EXIT"))
            {
                Application.Quit(); // exit the game
            }
        }
        else
        {
                GUI.Box(new Rect(Screen.width / 8, 10, 3 * Screen.width / 4, 3 * Screen.height / 4), "Выбор героя"); //a box to hold all the buttons

            if (GUI.Button(new Rect(Screen.width / 8, Screen.height / 8+10, 3 * Screen.width / 4, Screen.height / 8), "Рыцарь"))
            {
                
                UnityEngine.SceneManagement.SceneManager.LoadScene(1); //open the game scene

            }
            if (GUI.Button(new Rect(Screen.width / 8, Screen.height / 8+110, 3 * Screen.width / 4, Screen.height / 8), "Воин"))
            {
                hero.Character_init("Золтан", "Warior", 8, 3, 4, 0);
                UnityEngine.SceneManagement.SceneManager.LoadScene(1); //open the game scene

            }
            if (GUI.Button(new Rect(Screen.width / 8, Screen.height / 8+210 , 3 * Screen.width / 4, Screen.height / 8), "Варвар"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(1); //open the game scene

            }
            if (GUI.Button(new Rect(Screen.width / 8, Screen.height / 8+310, 3 * Screen.width / 4, Screen.height / 8), "Разбойник"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(1); //open the game scene

            }
            if (GUI.Button(new Rect(Screen.width / 8, Screen.height / 8+410, 3 * Screen.width / 4, Screen.height / 8), "Лучник"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(1); //open the game scene

            }
        }
        
    }
 


}
 

