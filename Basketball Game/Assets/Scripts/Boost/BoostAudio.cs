﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostAudio : MonoBehaviour
{
    public void PlayAudio()
    {
        GetComponent<AudioSource>().Play(); //will play specific audio source attached in inspector
    }
}