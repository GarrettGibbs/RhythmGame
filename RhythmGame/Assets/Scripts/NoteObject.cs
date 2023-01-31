using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NoteOptions {Left, Up, Down, Right, Empty};

public class NoteObject : MonoBehaviour
{
    private bool canBePressed = false;
    [SerializeField] KeyCode keyToPress;
    private float noteSpeed;
    //float timeCheck = 0f;

    private void Start() {
        noteSpeed = GameManager.instance.noteSpeed;
    }

    void Update()
    {
        //timeCheck += Time.deltaTime;
        if(Input.GetKeyDown(keyToPress) && canBePressed) {
            GameManager.instance.NoteHit();
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0f, noteSpeed * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Activator") {
            canBePressed = true;
            //print($"Start: {timeCheck}");
        } else if(other.tag == "MissArea") {
            GameManager.instance.NoteMissed();
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Activator") {
            canBePressed = false;
            //print($"End: {timeCheck}");
        } else if (other.tag == "MissArea") {
            Destroy(gameObject);
        }
    }
}
