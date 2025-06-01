using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class dooropen : MonoBehaviour
{
    private GameManager gameManager;
    Animation animation;

    // Use this for initialization
    void Start()
    {
        animation = GetComponent<Animation>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.levelComplete)
        {
            OpenDoor();
        }
    }
    void OpenDoor()
    {
        if (Input.GetKeyDown("f"))
            animation.Play();
    }
}
