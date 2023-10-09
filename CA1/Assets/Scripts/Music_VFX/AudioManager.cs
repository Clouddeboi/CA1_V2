
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //video tutorial followed: https://www.youtube.com/watch?v=N8whM1GjH4w&t=102s&ab_channel=RehopeGames

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-----------Audio Clip----------")]
    public AudioClip Background;
    public AudioClip Jump;
    public AudioClip Dash;
    public AudioClip Death;
    public AudioClip WallJumping;
    public AudioClip WallSliding;
    public AudioClip JumpPad;
    public AudioClip Teleporter;

    private void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
