using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] GameObject LeftNote;
    [SerializeField] GameObject UpNote;
    [SerializeField] GameObject DownNote;
    [SerializeField] GameObject RightNote;

    [SerializeField] GameObject[] SpawnPoints;

    [SerializeField] Song song;
    [SerializeField] List<Note> notes;
    private float songTime = 0;

    private void Start() {
        notes = song.SetupSong();
    }

    private void Update() {
        if (!GameManager.instance.startPlaying || notes.Count == 0) return;
        
        if(songTime >= notes[0].time - GameManager.instance.TravelTime) {
            spawnNote();
        }

        songTime += Time.deltaTime;
    }

    private void spawnNote() {
        AddNote(notes[0].note);
        if (notes[0].secondNote != NoteOptions.Empty) {
            GameObject go = AddNote(notes[0].secondNote);
            go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y - .065f, go.transform.position.z);
        }
        notes.RemoveAt(0);
    }

    private GameObject AddNote(NoteOptions no) {
        switch (no) {
            case NoteOptions.Left:
                return Instantiate(LeftNote, SpawnPoints[0].transform);
            case NoteOptions.Up:
                return Instantiate(UpNote, SpawnPoints[1].transform);
            case NoteOptions.Down:
                return Instantiate(DownNote, SpawnPoints[2].transform);
            case NoteOptions.Right:
                return Instantiate(RightNote, SpawnPoints[3].transform);
        }
        return null;
    }
}
