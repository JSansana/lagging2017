using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLooper : MonoBehaviour
{
    public float loopStartTime = 10.97f;
    private float pauseTime;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(LoopMusic());
    }

    IEnumerator LoopMusic()
    {
        // Start the music
        audioSource.Play();

        // Wait until the loop start time is reached
        yield return new WaitForSeconds(loopStartTime);

        // Loop the music
        while (true)
        {
            // Wait for the entire length of the audio clip minus the loop start time
            yield return new WaitForSeconds(audioSource.clip.length - loopStartTime);

            // Restart the music from the loop start time
            audioSource.time = loopStartTime;
            audioSource.Play();
        }
    }

    public void PauseMusic()
    {
        audioSource.Pause();
        pauseTime = audioSource.time;
    }

    public void ResumeMusic()
    {
        audioSource.time = pauseTime;
        audioSource.Play();
    }
}
