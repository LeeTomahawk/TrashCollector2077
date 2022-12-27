using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSoundEffect()
    {

        if (soundPlayer != null)
            soundPlayer.Play();
        else
            soundPlayer.Pause();


        soundPlayer.volume = 0.05f;
    }
}
