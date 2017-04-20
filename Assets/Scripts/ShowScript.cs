using UnityEngine;

public class ShowScript : MonoBehaviour
{
     public GameObject scroll;
     public GameObject trigger;
     public GameObject menuScreenExit, menuScreenResume;

     // Use this for initialization
     private void Start()
     {
          scroll.SetActive(false);
          menuScreenExit.SetActive(false);
          menuScreenResume.SetActive(false);
     }

     // Update is called once per frame
     private void Update()
     {
          if (Input.GetKeyDown(KeyCode.Escape))
          {
               menuScreenExit.SetActive(true);
               menuScreenResume.SetActive(true);
          }
     }

     private void OnTriggerEnter2D(Collider2D collision)
     {
          if (trigger.tag == "Scroll")
          {
               scroll.SetActive(true);
          }
     }

     private void OnTriggerExit2D(Collider2D collision)
     {
          scroll.SetActive(false);
     }
}