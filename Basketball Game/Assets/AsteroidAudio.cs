using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAudio : MonoBehaviour
{
    public void PlayAudio()
    {
        GetComponent<AudioSource>().Play();
    }
}
