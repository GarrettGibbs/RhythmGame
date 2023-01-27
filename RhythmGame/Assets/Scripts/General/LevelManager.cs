using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject player;
    public GameObject menuCenter;
    public AudioManager audioManager;
    public CircleTransition circleTransition;
    public ProgressManager progressManager;
    public DialogueManager dialogueManager;
    public InSceneSettings inSceneSettings;

    public bool respawning = false;
    public bool gameEnd = false;
    public bool inSettings = false;

    private void Awake() {
        audioManager = FindObjectOfType<AudioManager>();
        circleTransition = FindObjectOfType<CircleTransition>();
        progressManager = FindObjectOfType<ProgressManager>();
        if (player != null) {
            circleTransition.player = player.transform;
        } else if (menuCenter != null) {
            circleTransition.player = menuCenter.transform;
        }
    }

    private async void Start() {
        progressManager.currentLevel = SceneManager.GetActiveScene().buildIndex;
        //audioManager.TransitionMusic(MusicType.Peaceful);
        //if (!progressManager.firstTimeAtMenu) {
        //    await Task.Delay(1000);
        //    circleTransition.OpenBlackScreen();
        //}
    }

    public async void RestartLevel() {
        await Task.Delay(1000);
        inSceneSettings.RestartScene();
        respawning = true;
    }

    public async void NextLevel() {
        circleTransition.CloseBlackScreen();
        progressManager.firstTimeAtMenu = false;
        await Task.Delay(1000);
        switch (progressManager.currentLevel) {
            case 0:
                SceneManager.LoadScene(1);
                break;
            case 1:
                SceneManager.LoadScene(0);
                break;
        }
    }

    public async void SpecificLevel(int destination) {
        circleTransition.CloseBlackScreen();
        progressManager.firstTimeAtMenu = false;
        await Task.Delay(1000);
        SceneManager.LoadScene(destination);
    }
}
