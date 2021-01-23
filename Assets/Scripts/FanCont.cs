using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanCont : MonoBehaviour
{
    public static AudioClip fanSound;
    private static AudioSource audioSrc;
    private Wind wind;
    
    // Start is called before the first frame update
    void Start()
    {
        fanSound = Resources.Load<AudioClip>("SFX/fan");
        audioSrc = GetComponent<AudioSource>();
        wind = GameObject.Find("Globals/Wind").GetComponent<Wind>();
    }


    // Update is called once per frame
    void Update()
    {
        if (wind.isActive) {
            Debug.Log("Fan pls");
            PlayFan();
        } else {
            StopFan();
        }
    }
    
    public static void PlayFan()
    {
        if (!audioSrc.isPlaying) {
            audioSrc.loop = true;
            audioSrc.clip = fanSound;
            audioSrc.Play();
        }
    }

    public static void StopFan()
    {
        if (audioSrc.isPlaying)
        {
            audioSrc.Pause();
        }
        
    }
}
