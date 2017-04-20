using UnityEngine;

public class PuzzleOneScript : MonoBehaviour
{
     public GameObject PuzzleStatue;
     public GameObject Key;
     public GameObject greenButton;
     public GameObject redbutton;
     public new AudioClip audio;

     // Use this for initialization
     private void Start()
     {
          GetComponent<AudioSource>().clip = audio;
          GetComponent<AudioSource>().playOnAwake = false;
          Key.SetActive(false);
          greenButton.SetActive(false);
          redbutton.SetActive(true);
     }

     // Update is called once per frame
     private void Update()
     {
     }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (PuzzleStatue.tag == "Puzzle1")
          {
               Key.SetActive(true);
               GetComponent<AudioSource>().Play();
               greenButton.SetActive(true);
               redbutton.SetActive(false);
          }
     }
}