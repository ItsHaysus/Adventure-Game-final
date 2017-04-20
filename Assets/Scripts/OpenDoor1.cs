using UnityEngine;

public class OpenDoor1 : MonoBehaviour
{
     public GameObject Key;
     public GameObject door1;
     private Inventory inv;
     public new AudioClip audio;

     private void Update()
     {
          GetComponent<AudioSource>().clip = audio;
          GetComponent<AudioSource>().playOnAwake = false;
     }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (Key.tag == "Key1")
          {
               inv = FindObjectOfType<Inventory>();
               Door1 door = FindObjectOfType<Door1>();
               GetComponent<AudioSource>().Play();
               Item item = ScriptableObject.CreateInstance<Item>();
               item.sprite = Key.GetComponent<SpriteRenderer>().sprite;
               //SceneController.addItemToInventory(inv);
               inv.AddItem(item);
               door.addKey(item);
               //Destroy(door1);
               Destroy(Key);
          }
     }
}