using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song1 : Song {
    public override Dictionary<float, NoteOptions> GetSongNotes() {
        return new Dictionary<float, NoteOptions>() {
            {7.73f, NoteOptions.Left},
            {8.58f, NoteOptions.Up},
            {8.92f, NoteOptions.Down},
            {10f, NoteOptions.Left},
            {10.42f, NoteOptions.Up},
            {11.4f, NoteOptions.Left},
            {11.6f, NoteOptions.Up},
            {12.2f, NoteOptions.Right},
            {12.38f, NoteOptions.Down},
            {12.67f, NoteOptions.Left},
            {12.82f, NoteOptions.Up},
            {13.79f, NoteOptions.Down},
            {14.53f, NoteOptions.Right},
            {15.45f, NoteOptions.Left},
            {15.86f, NoteOptions.Up},
            {16.8f, NoteOptions.Left},
            {17f, NoteOptions.Up},
            {18.35f, NoteOptions.Down},
            {18.59f, NoteOptions.Right},
            {18.9f, NoteOptions.Up},
            {19.05f, NoteOptions.Left},
            {19.6f, NoteOptions.Up},
            {19.84f, NoteOptions.Left},
            {20.64f, NoteOptions.Down},
            {21.36f, NoteOptions.Down},
            {21.96f, NoteOptions.Down},
            {22.55f, NoteOptions.Left},
            {22.7f, NoteOptions.Up},
            {23.65f, NoteOptions.Left},
            {23.92f, NoteOptions.Up},
            {24.56f, NoteOptions.Right},
            {24.95f, NoteOptions.Right},
            {25.39f, NoteOptions.Down},
            {25.75f, NoteOptions.Right},
            {25.97f, NoteOptions.Down},
            {26.25f, NoteOptions.Right},
            {26.43f, NoteOptions.Down},
            {26.93f, NoteOptions.Left},
            {27.22f, NoteOptions.Down},
        };
    }
}
