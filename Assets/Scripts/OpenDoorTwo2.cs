using UnityEngine;

public class OpenDoorTwo2 : MonoBehaviour
{
     public GameObject MercyStatue1;
     public GameObject doorTwo1;
     public GameObject ButtonEnabled1;
     public GameObject statue1;
     public GameObject statue2;
     public new AudioClip audio;

     // Use this for initialization
     private void Start()
     {
          GetComponent<AudioSource>().clip = audio;
          GetComponent<AudioSource>().playOnAwake = false;
          ButtonEnabled1.SetActive(false);
     }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (MercyStatue1.tag == "MercyPuzzle")
          {
               Destroy(doorTwo1);
               GetComponent<AudioSource>().Play();
               ButtonEnabled1.SetActive(true);
               Destroy(statue1);
               Destroy(statue2);
          }
     }
}