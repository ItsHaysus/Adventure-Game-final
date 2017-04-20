using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenUI : MonoBehaviour
{
     // Update is called once per frame
     private void Update()
     {
          if (Input.GetKey("escape"))
               Application.Quit();
     }

     public void StartGame()
     {
          SceneManager.LoadScene("Level1");
     }

     public void QuitGame()
     {
          Application.Quit();
     }
}