using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene2 : MonoBehaviour
{
     public GameObject WrongStatue2;
     public GameObject DeathScene;
     // Use this for initialization

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (WrongStatue2.tag == "Death")
          {
               DeathScene.SetActive(true);
               System.Threading.Thread.Sleep(2000);
               SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          }
     }
}