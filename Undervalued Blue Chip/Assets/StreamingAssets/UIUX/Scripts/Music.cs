using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider backVolume;
    public AudioSource audio;

    private float backVol = 1f;
    private void Start()
    {
        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        backVolume.value = backVol;
        audio.volume = backVolume.value;
    }

    // Update is called once per frame
    void Update()
    {
        SoundSlider();
    }

    public void SoundSlider()
    {
        audio.volume = backVolume.value;
        backVol = backVolume.value;
        PlayerPrefs.SetFloat("backvol", backVol);
    }
}
