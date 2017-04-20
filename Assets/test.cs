using UnityEngine;

public class test : MonoBehaviour
{
     // Use this for initialization
     private void Start()
     {
     }

     private void Update()
     {
          if (Input.GetMouseButtonDown(0))
          {
               // target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
               //target.z = transform.position.z;
          }

          //transform.position = Vector3.MoveTowards
          //(transform.position, target, speed * Time.deltaTime);
     }

     private void Flip()
     {
     }
}