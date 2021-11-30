using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BricksScript : MonoBehaviour
{
    private static int brickCount = 20;
    public Text youWinText;
    public GameObject crystal;

    private Vector3 crystalPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter()
    {
        brickCount -= 1;

        if (brickCount <= 0)
        {
            // object.text sets UI text
            youWinText.text = "You Win!";
            // object.gameObject.SetActive(bool) sets whether object shows or not
            youWinText.gameObject.SetActive(true);
        }

        // Destroys collided object
        spawnCrystal(this.transform.position.x, this.transform.position.y);
        Destroy(gameObject);
        
    }

    private void spawnCrystal(float x, float y)
    {
        crystalPosition = new Vector3(x, y, 0);
        Instantiate(crystal, crystalPosition, Quaternion.identity);
    }
}
