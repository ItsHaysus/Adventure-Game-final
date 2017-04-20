using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
     private PlayerStats playerStats;
     private bool isNewGame;
     private string isNewGameKey;
     public int hasUnlockedKeys; //keep track of how many keys has the player unlocked, if 0 then lock all the doors, if 1 unlock first door, etc...
     public GameObject[] doors; //array of doors, to delete for resumed states


     //ui stuff
     public Text playerHealth;

     //gameplay stuff
     public int remainingHealth;
     public GameObject player;
     float currentPosX;
     float currentPosY;
     float currentPosZ;

     //playerstats
     private void Start()
     {
          playerStats = FindObjectOfType<PlayerStats>();
          //load up if its not a new game
          isNewGameKey = PlayerPrefs.GetString("isNewGame");

          //set keys for new game or old game
          if (isNewGameKey == "false")
          {
               isNewGame = false;
          }
          else
          {
               isNewGame = true;
          }

          //choose if new game or saved game
          if (isNewGame)
          {
               CreateNewLevel();
               SaveStats();
               PlayerPrefs.SetString("isNewGame", "false");
               PlayerPrefs.SetInt("UnlockedKeys", 0);
          }
          else
          {
               GetStats();
               hasUnlockedKeys = PlayerPrefs.GetInt("UnlockedKeys");
               DeleteUnlockedDoors();
               Debug.LogError("Loaded saved level");
          }
     }

     private void Update()
     {
          HealthMonitor();
     }

     private void CreateNewLevel()
     {
          //new game stats
          playerStats.health = 20;
          remainingHealth = playerStats.health;
          playerStats.strenght = 10;
          playerStats.defense = 8;
          playerStats.currentArmor = "Armor1";
          playerStats.currentSword = "Sword1";
          Debug.LogError("Loaded new level");
     }

     private void SaveStats()
     {
          //save stats
          PlayerPrefs.SetInt("PlayerHealthRemaning", remainingHealth);
          PlayerPrefs.SetInt("PlayerHealth", playerStats.health);
          PlayerPrefs.SetInt("PlayerStrenght", playerStats.strenght);
          PlayerPrefs.SetInt("PlayerDefense", playerStats.defense);
          PlayerPrefs.SetString("currentArmor", playerStats.currentArmor);
          PlayerPrefs.SetString("currentSword", playerStats.currentSword);
     }

     private void GetStats()
     {
          remainingHealth = PlayerPrefs.GetInt("PlayerHealthRemaning");
          playerStats.health = PlayerPrefs.GetInt("PlayerHealth");
          playerStats.strenght = PlayerPrefs.GetInt("PlayerStrenght");
          playerStats.defense = PlayerPrefs.GetInt("PlayerDefense");
          playerStats.currentArmor = PlayerPrefs.GetString("currentArmor");
          playerStats.currentSword = PlayerPrefs.GetString("currentSword");

          //load last position
          transform.position = new Vector3(currentPosX, currentPosY, currentPosZ);
     }

     private void DeleteUnlockedDoors()
     {
          if (hasUnlockedKeys > 0) //if has unlocked at least 1 door
          {
               //delete the number of doors it has unlocked
               //doors[0]..door[n]
               for (int i = 0; i < hasUnlockedKeys - 1; i++)
               {
                    Destroy(doors[i]);
               }
          }
     }

     private void HealthMonitor()
     {
          playerHealth.text = "HP: " + remainingHealth;
          playerHealth.transform.position = new Vector3(Screen.width /2 + 50, Screen.height-50, 10);

          if (remainingHealth == (playerStats.health/4))
          {
               playerHealth.color = Color.red;
          }
          else if(remainingHealth == (playerStats.health / 2))
          {
               playerHealth.color = Color.yellow;
          }

          if(remainingHealth < playerStats.health)
          {
               PlayerPrefs.SetInt("PlayerHealthRemaning", remainingHealth);
          }
     }

     //BIG MAAAAYBEE
     private void RememberPosition()
     {
           currentPosX = player.transform.position.x;
           currentPosY = player.transform.position.y;
           currentPosZ = player.transform.position.z;

          PlayerPrefs.SetFloat("currentPosX", currentPosX);
          PlayerPrefs.SetFloat("currentPosY", currentPosY);
          PlayerPrefs.SetFloat("currentPosZ", currentPosZ);
     }
           
}