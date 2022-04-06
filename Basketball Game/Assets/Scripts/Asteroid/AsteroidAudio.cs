using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAudio : MonoBehaviour
{
    public void PlayAudio()
    {
        GetComponent<AudioSource>().Play(); //will play specific audio source attached in inspector
    }
}
