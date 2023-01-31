using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Song : MonoBehaviour
{
    public Dictionary<float, NoteOptions> notes;

    public List<Note> SetupSong() {
        notes = GetSongNotes();

        List<Note> list = new List<Note>();
        foreach(KeyValuePair<float, NoteOptions> songNote in notes) {
            if ((notes.ContainsKey(songNote.Key - .001f))) continue;
            Note n = new Note();
            NoteOptions secondNote = NoteOptions.Empty;
            if(notes.ContainsKey(songNote.Key + .001f)) {
                secondNote = notes[songNote.Key + .001f];
            }
            n.SetupNotes(songNote.Key, songNote.Value, secondNote);
            list.Add(n);
        }
        return list;
    }

    public abstract Dictionary<float, NoteOptions> GetSongNotes();
}
