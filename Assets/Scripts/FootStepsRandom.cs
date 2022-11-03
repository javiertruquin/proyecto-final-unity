using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepsRandom : MonoBehaviour
{   public Vector3 PlayerPosChange = new Vector3(0.5f, 0, 0.5f);
    public Transform PlayerMov;
    public AudioClip[] sounds;
    private AudioSource source;
    [Range(0.1f,0.5f)]
    public float VolumeChange= 0.2f;
    [Range(0.1f,0.5f)]
    public float PitchChange = 0.2f;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Input.anyKeyDown) 
        {
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.volume = Random.Range(1 - VolumeChange, 1);
            source.pitch = Random.Range(1 - PitchChange, 1 + PitchChange);
            source.PlayOneShot(source.clip); 
        }

     }
        
}
