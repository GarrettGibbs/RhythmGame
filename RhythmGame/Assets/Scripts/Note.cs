using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note
{
    public float time;
    public NoteOptions note;
    public NoteOptions secondNote;

    public void SetupNotes(float t, NoteOptions no, NoteOptions s) {
        time = t;
        note = no; 
        secondNote = s;
    }
}
