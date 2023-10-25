using UnityEngine;
using UnityEngine.Audio;//adding audio library
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    //video tutorial followed: https://www.youtube.com/watch?v=G-JUp8AMEx0&ab_channel=RehopeGames
    [SerializeField] private AudioMixer myMixer;//accesses audio mixer
    [SerializeField] private Slider musicSlider;//access music slider
    [SerializeField] private Slider SFXSlider;//accesses SFX slider
    
    private void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))//loads players prefered volume
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
        }   
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20);//gets logmiritic value of volume slider and multiplys it by 20
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

        public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume)*20);//gets logmiritic value of volume slider and multiplys it by 20
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");//equates stored value to the value of the slider
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");

        SetMusicVolume();
        SetSFXVolume();
    }
}
