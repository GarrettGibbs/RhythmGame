using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
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

    [SerializeField] TMP_Text timeText;
    private float timeInSong;

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

                StartSong();
            }
        } else {
            timeInSong += Time.deltaTime;
            timeText.text = timeInSong.ToString();
            if (Input.GetKeyDown(KeyCode.Space)) {
                Time.timeScale = 0f;
                theMusic.Pause();
            } else if (Input.GetKeyDown(KeyCode.Return)) {
                Time.timeScale = 1f;
                theMusic.Play();
            }
        }
    }

    private async void StartSong() {
        await Task.Delay(6380);
        theMusic.Play();
    }

    public void NoteHit() {
        print("Hit on time!");
    }

    public void NoteMissed() {
        print("Missed");
    }
}
