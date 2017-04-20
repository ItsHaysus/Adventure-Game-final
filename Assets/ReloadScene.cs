using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
     public GameObject WrongStatue1;

     //public GameObject DeathScene;
     // Use this for initialization
     private void Start()
     {
          //   DeathScene.SetActive(false);
     }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (WrongStatue1.tag == "Death")
          {
               //  DeathScene.SetActive(true);
               System.Threading.Thread.Sleep(2000);
               SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          }
     }
}