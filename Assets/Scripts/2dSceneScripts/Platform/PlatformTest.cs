using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTest : MonoBehaviour
{
    public float speed = 2f;
    bool isMovingRight = false;

    // References to positions
    public Transform pos1Ref;
    public Transform pos2Ref;
    Transform targetPosRef;

    public Transform platformRef;
    Rigidbody2D platformRB;

    float direction = -1f;

    // Start is called before the first frame update
    void Start()
    {
        platformRB = platformRef.GetComponent<Rigidbody2D>();
        targetPosRef = pos2Ref;
        direction = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        // ALT: Vector3.Distance(platformRef.position, targetPosRef.position)
        Vector3 posDiff = platformRef.position - targetPosRef.position;
        if (posDiff.magnitude <= 0.5f)
        {
            if (!isMovingRight)
            {
                // Move to the right
                isMovingRight = true;
                direction = 1f;
                targetPosRef = pos1Ref;
            }
            else
            {
                // Move to the left
                isMovingRight = false;
                direction = -1f;
                targetPosRef = pos2Ref;
            }
        }

        // Vector2.right (1, 0) * -1f * 2f
        // (-1, 0) * 2f
        // (-2, 0) <-- moving to the left
        platformRB.velocity = Vector2.right * direction * speed;
    }
}
