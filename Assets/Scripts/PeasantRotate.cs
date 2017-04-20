using UnityEngine;

public class PeasantRotate : MonoBehaviour
{
     public float speed = 1.5f;

     private Vector2 moveLocation;
     private Vector3 mouseRotation;
     private Vector3 mousePosition;
     private Vector2 currentLocation;
     private Vector3 newPos;

     // Use this for initialization
     private void Start()
     {
     }

     // Update is called once per frame
     private void Update()
     {
          if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
          {
               //target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
               //Save the position of the location clicked
               mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
               moveLocation = new Vector2(mousePosition.x, mousePosition.y);
               currentLocation = new Vector2(transform.position.x, transform.position.y);
          }
     }
}