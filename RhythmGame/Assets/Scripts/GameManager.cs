using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioSource theMusic;
    public bool startPlaying;
    [SerializeField] BeatScroller theBS; 

    public static GameManager instance;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (!startPlaying) {
            if (Input.anyKeyDown) {
                if (Input.GetKeyDown(KeyCode.Escape)) return;
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit() {
        print("Hit on time!");
    }

    public void NoteMissed() {
        print("Missed");
    }
}
