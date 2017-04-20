using UnityEngine;

public class CameraFollow : MonoBehaviour
{
     public Transform target;
     public float cameraSpeed = 5.0f;

     private Vector3 offset;

     // Use this for initialization
     private void Start()
     {
          offset = transform.position - target.position;
     }

     // Update is called once per frame
     private void FixedUpdate()
     {
          Vector3 camPos = target.position + offset;

          transform.position = Vector3.Lerp(transform.position, camPos, cameraSpeed * Time.deltaTime);
     }
}