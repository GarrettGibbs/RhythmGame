using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song1 : Song {
    public override Dictionary<float, NoteOptions> GetSongNotes() {
        return new Dictionary<float, NoteOptions>() {
            {10, NoteOptions.Left},
            {11, NoteOptions.Up},
            {12, NoteOptions.Left},
            {12.5f, NoteOptions.Up},
            {13, NoteOptions.Right},
            {13.001f, NoteOptions.Left},
        };
    }
}
