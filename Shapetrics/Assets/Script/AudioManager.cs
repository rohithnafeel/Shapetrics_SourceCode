using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource sfxSource;

    public AudioClip switchSound;
    public AudioClip matchSound;
    public AudioClip gameOverSound;
    public AudioClip buttonSound;

    private void Awake()
    {
        Instance = this;

        if (sfxSource == null)
        {
            sfxSource = GetComponent<AudioSource>();
        }
    }

    public void PlaySwitch()
    {
        sfxSource.PlayOneShot(switchSound);
    }

    public void PlayMatch()
    {
        sfxSource.PlayOneShot(matchSound);
    }

    public void PlayGameOver()
    {
        sfxSource.PlayOneShot(gameOverSound);
    }

    public void PlayButton()
    {
        sfxSource.PlayOneShot(buttonSound);
    }
}