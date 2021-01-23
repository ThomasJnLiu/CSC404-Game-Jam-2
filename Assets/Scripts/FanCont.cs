using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanCont : MonoBehaviour
{
    public static AudioClip fanSound;
    private static AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        fanSound = Resources.Load<AudioClip>("SFX/Large Fan 20 sec loop.wav");

        audioSrc = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void PlayFan()
    {
        audioSrc.loop = true;
        audioSrc.clip = fanSound;
        audioSrc.Play();
    }

    public static void StopFan()
    {
        if (audioSrc.isPlaying)
        {
            audioSrc.Pause();
        }
        
    }
}
