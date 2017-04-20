using UnityEngine;

public class FlipScript : MonoBehaviour
{
     private float _posX;
     private Vector2 moveLocation;
     private Vector3 mouseRotation;
     private Vector3 mousePosition;
     private Vector2 currentLocation;

     // Use this for initialization
     private void Start()
     {
     }

     private void Update()
     {
          if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
          {
               mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
               moveLocation = new Vector2(mousePosition.x, mousePosition.y);
               currentLocation = new Vector2(transform.position.x, transform.position.y);

               if (moveLocation.x <= currentLocation.x)
               {
                    transform.eulerAngles = new Vector3(0, 180, 0); // Normal
               }
               else
               {
                    transform.eulerAngles = new Vector3(0, 0, 0); // Flipped
               }
          }
     }
}