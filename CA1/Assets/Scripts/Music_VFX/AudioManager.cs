using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //video tutorial followed: https://www.youtube.com/watch?v=N8whM1GjH4w&t=102s&ab_channel=RehopeGames

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-----------Audio Clip----------")]
    public AudioClip Background;//background song
    public AudioClip Jump;//jumping sound
    public AudioClip Dash;
    public AudioClip Death;
    public AudioClip JumpPad;
    public AudioClip Teleporter;
    public AudioClip ButtonClick;//on every button click excluding start and restart
    public AudioClip StartButtonClick;

    private void Start()//will always play this clip from the start of the game
    {
        musicSource.clip = Background;
        musicSource.loop = true;//loops track
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);//plays the clip once when called
    }

}
