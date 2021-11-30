
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 0.25f;
    public Text score;

    private int scoreValue;
    private Vector3 playerPos = new Vector3(0.0003572332f, 0.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -7.4f, 7.4f), 1.31f, 0f);
        transform.position = playerPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Crystal")
            return;
        scoreValue++;
        score.text = "Score: " + scoreValue.ToString();
    }
}
