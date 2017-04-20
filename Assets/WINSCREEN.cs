using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WINSCREEN : MonoBehaviour
{
     // public GameObject winscreen;
     public GameObject winscenareo;

     // Use this for initialization
     private void Start()
     {
          //   winscreen.SetActive(false);
     }

     // Update is called once per frame
     private void Update()
     {
     }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (winscenareo.tag == "Win")
          {
               //  winscreen.SetActive(true);
               WinScreen();
               SceneManager.LoadScene("MainScene");
          }
     }

     private IEnumerator WinScreen()
     {
          // winscreen.SetActive(true);
          yield return new WaitForSeconds(3.0f);
          // SceneManager.LoadScene("MainScene");
     }
}