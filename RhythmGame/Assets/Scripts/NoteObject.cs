using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    private bool canBePressed = false;
    [SerializeField] KeyCode keyToPress;

    void Update()
    {
        if(Input.GetKeyDown(keyToPress) && canBePressed) {
            GameManager.instance.NoteHit();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Activator") {
            canBePressed = true;
        } else if(other.tag == "MissArea") {
            GameManager.instance.NoteMissed();
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Activator") {
            canBePressed = false;
        } else if (other.tag == "MissArea") {
            Destroy(gameObject);
        }
    }
}
