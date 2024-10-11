using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSFXPlayer : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    private void Start()
    {
        audioSource.pitch = Random.Range(0.85f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            Destroy(this.gameObject);
        }
    }
}
