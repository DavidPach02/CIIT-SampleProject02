using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSFX : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.pitch = Random.Range(0.85f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        // if the audio is done playing, destroy the object
        if (!audioSource.isPlaying)
        {
            Destroy(this.gameObject);
        }
    }
}
