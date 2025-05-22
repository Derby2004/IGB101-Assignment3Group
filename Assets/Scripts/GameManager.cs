using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Text pickupText;

    public AudioSource[] audioSources;
    public float audioProximity = 10.0f;

    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }

    private void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
        PlayAudioSample();
    }

    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }

    private void PlayAudioSample()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if (Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }
            }
        }
    }
}
