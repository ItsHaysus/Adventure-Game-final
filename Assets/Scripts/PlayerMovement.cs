using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public float speed = 1.0f;

     private void Update()
     {
          var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

          transform.position += move * speed * Time.deltaTime;

          if (Input.GetKeyDown(KeyCode.LeftShift))
          {
               speed = 4.0f;
          }
          else if (Input.GetKeyUp(KeyCode.LeftShift))
          {
               speed = 1.0f;
          }
     }
}