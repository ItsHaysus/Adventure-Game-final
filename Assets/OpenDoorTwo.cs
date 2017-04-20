using UnityEngine;

public class OpenDoorTwo : MonoBehaviour
{
     public GameObject MercyStatue;
     public GameObject doorTwo;
     public GameObject ButtonEnabled;

     // Use this for initialization
     private void Start()
     {
          ButtonEnabled.SetActive(false);
     }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (MercyStatue.tag == "MercyPuzzle")
          {
               Destroy(doorTwo);
               ButtonEnabled.SetActive(true);
          }
     }

     // Update is called once per frame
     private void Update()
     {
     }
}