using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBGM : MonoBehaviour
{
    private AudioSource[] audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponents<AudioSource>();
        audio[0].Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeMusic()
    {
        audio[0].Stop();
        audio[1].Play();
    }
}
