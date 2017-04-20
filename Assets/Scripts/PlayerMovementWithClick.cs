using UnityEngine;

public class PlayerMovementWithClick : MonoBehaviour
{
     private Vector3 targetPos;
     private Vector3 oldposition;

     // private int keepTrack = 0;
     public new AudioClip audio;

     public GameObject player;

     private void Start()
     {
          oldposition = transform.position;
          targetPos = transform.position;
          GetComponent<AudioSource>().clip = audio;
          GetComponent<AudioSource>().playOnAwake = false;
     }

     private void Update()
     {
          if (Input.GetMouseButton(0))
          {
               targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
               targetPos.z = transform.position.z;

               if (transform.position != targetPos)
               {
                    GetComponent<AudioSource>().Play();
               }
               GetComponent<AudioSource>().Play();
          }

          transform.position = Vector3.MoveTowards(transform.position, targetPos, 3 * Time.deltaTime);

          if (transform.position == targetPos)
          {
               GetComponent<AudioSource>().Stop();
          }
     }
}