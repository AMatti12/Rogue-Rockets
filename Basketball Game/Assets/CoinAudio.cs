﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAudio : MonoBehaviour
{
    public void PlayAudio()
    {
        GetComponent<AudioSource>().Play();
    }
}
