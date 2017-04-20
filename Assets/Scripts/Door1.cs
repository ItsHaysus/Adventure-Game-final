using UnityEngine;

public class Door1 : MonoBehaviour
{
     private Item keyItem;
     public GameObject door;

     public void addKey(Item itemToAdd)
     {
          keyItem = itemToAdd;
     }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (collision.transform.name == "Peasant")
          {
               Inventory data = FindObjectOfType<Inventory>();
               if (data.hasKey(keyItem) && keyItem != null)
               {
                    data.RemoveItem(keyItem);
                    Destroy(door);
               }
          }
     }
}