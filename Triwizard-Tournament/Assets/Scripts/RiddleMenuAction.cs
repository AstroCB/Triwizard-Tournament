﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleMenuAction : MonoBehaviour
{
    public GameObject thisMenu;
    public GameObject endMenu;
    public GameObject camera;
    public GameObject timer;

    //Correct choice, player continues
    public void Correct()
    {
        thisMenu.SetActive(false);
    }

    //Wrong choice, player loses
    public void Wrong()
    {
        endMenu.SetActive(true);
        endMenu.transform.position = camera.transform.position + camera.transform.forward * 0.75f;
        endMenu.transform.rotation = camera.transform.rotation;
        timer.GetComponent<CountdownTimer>().gameOver = true;
    }
}
