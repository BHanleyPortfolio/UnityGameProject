using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterScript : MonoBehaviour

{
    private int livesCount;
    public Text livesText;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        livesCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Crystal")
        {

            livesCount -= 1;

            if (livesCount > 0)
            {
                livesText.text = "Lives: " + livesCount.ToString();
            }
            else if (livesCount <= 0)
            {
                livesText.text = "Lives: " + livesCount.ToString();
                gameOverText.text = "Game Over";
                gameOverText.gameObject.SetActive(true);
            }

        }
    }
}
