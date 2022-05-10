using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    public bool audioIsOn;

    private void Start()
    {
        audioIsOn = true;
    }
    public void ToggleAudio()
    {
        if (!audioIsOn)
        {
            AudioListener.volume = 1;
            audioIsOn = true;
        }
        else
        {
            AudioListener.volume = 0;
            audioIsOn = false;
        }
    }
}
