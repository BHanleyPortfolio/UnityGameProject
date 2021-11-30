using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float ballInitialVelocity = 600f;

    private Rigidbody rb;
    private bool isBallInPlay;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && isBallInPlay == false)
        {
            transform.parent = null;
            isBallInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
        }
        else if (isBallInPlay == true && transform.position.y <= -2)
        {
            Vector3 ballPosition = new Vector3(0, 2.67f, 0);
            transform.SetPositionAndRotation(ballPosition, Quaternion.identity);
            isBallInPlay = false;
            rb.isKinematic = true;
            rb.AddForce(new Vector3(0, 0, 0));
        }
    }
}
