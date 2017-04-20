using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
     public GameObject menuScreen;
     public GameObject menuScreenResume;

     // Use this for initialization
     private void Start()
     {
     }

     // Update is called once per frame
     private void Update()
     {
          // this is used to make the menu follow the player camera and always be on the center.
          //it is not needed because we already made the canvas follow the player on the inventory script
          // Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
          //  pos.x = Mathf.Clamp01(pos.x);
          // pos.y = Mathf.Clamp01(pos.y);
          //  transform.position = Camera.main.ViewportToWorldPoint(pos);
     }

     public void resumegame()
     {
          menuScreen.SetActive(false); //sets the first button active
          menuScreenResume.SetActive(false); //sets the second menu button active
     }

     public void goToExit()
     {
          SceneManager.LoadScene("MainScene"); //if quit button is selected, load main scene
     }
}