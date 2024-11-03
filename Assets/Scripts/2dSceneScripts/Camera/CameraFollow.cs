using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 0, -1f);
    public float lerpSpeed = 10f;
    public Vector3 velocity = Vector3.zero;

    public TestPlayer playerRef;


    public Vector3 targetPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRef != null)
        {
            //this.transform.position = new Vector3(playerRef.transform.position.x, this.transform.position.y, this.transform.position.z);

            targetPos = playerRef.transform.position + offset;
            this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPos, ref velocity, lerpSpeed);

            //Vector3 targetPos = playerRef.transform.position + offset;
            //this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPos, ref velocity, lerpSpeed);
        }
    }
}
