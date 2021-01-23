using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static AudioClip jumpSound;
    private static AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        // THIS IS TEMP JUMP SOUND
        jumpSound = Resources.Load<AudioClip>("Sounds/jump");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
        }
    }

    public static void StopSound(string clip)
    {
        if (audioSrc.isPlaying)
        {
            audioSrc.Pause();
        }
    }
    
}
