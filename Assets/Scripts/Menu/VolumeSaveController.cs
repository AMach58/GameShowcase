using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSaveController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;

    [SerializeField] private Text volumeTextUI = null;

    public GameObject myCamera;
    private AudioSource MyAudio;
    
    public void Start()
    {
        LoadValues();
        //myCamera = GameObject.Find("Main Camera");
        
        MyAudio = GetComponent<AudioSource>();
       // MyAudio = myCamera.GetComponent<AudioSource>();

    }

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0.0");
    }

    public void SaveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("volumeValue");
        volumeSlider.value = volumeValue;
        //AudioListener.volume = volumeValue;
        MyAudio.volume = volumeValue;
    }
}
