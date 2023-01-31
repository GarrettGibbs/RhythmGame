using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioSource theMusic;
    public bool startPlaying;
    [SerializeField] BeatScroller theBS;
    public float beatTempo;
    public float noteSpeed;

    public float TravelTime = 5f;

    public static GameManager instance;

    void Start()
    {
        instance = this;
        noteSpeed = beatTempo / 60f;

        float travelRatio = 120f / beatTempo;
        TravelTime *= travelRatio;
    }

    void Update()
    {
        if (!startPlaying) {
            if (Input.anyKeyDown) {
                if (Input.GetKeyDown(KeyCode.Escape)) return;
                startPlaying = true;
                //theBS.hasStarted = true;

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
