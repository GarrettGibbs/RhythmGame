using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] SpriteRenderer theSR;
    [SerializeField] Sprite defautImage;
    [SerializeField] Sprite pressedImage;

    [SerializeField] KeyCode keyToPress;

    void Update()
    {
        if (Input.GetKeyDown(keyToPress)) {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress)) {
            theSR.sprite = defautImage;
        }
    }
}
