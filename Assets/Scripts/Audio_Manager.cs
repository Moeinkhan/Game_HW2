using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    [SerializeField]
    private AudioSource mainMusic;
    [SerializeField]
    private AudioSource alertMusic;

    void Start()
    {
        if (mainMusic.isPlaying == false)
            mainMusic.Play();
    }

    public void PlayAlertMusic()
    {
        if (alertMusic.isPlaying == false)
            alertMusic.Play();
    }

    public void StopAlertMusic()
    {
        if (alertMusic.isPlaying == true)
            alertMusic.Stop();
    }
}
