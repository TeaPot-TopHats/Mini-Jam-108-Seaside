using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    
    public void SetVolumeLevel (float sliderValue)
    {
        /*
         * represent the slider value as a log 10 and then multiply by 20. This will take the min and max value we set up in unity
         * and represent it is 0 to -80 on a logirthmic scale
         */
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

    
}
