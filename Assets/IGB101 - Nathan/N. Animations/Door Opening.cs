using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class DoorOpening : MonoBehaviour
{
    Animation animation;

    // Use this for initialization
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
            animation.Play();
    }


}
