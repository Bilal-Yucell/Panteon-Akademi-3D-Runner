using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI coinText;
    public PlayerController playerController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("End"))
        {
            Debug.Log("Congrats!");
            playerController.runningSpeed = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Collision"))
        {
            Debug.Log("Touched Obstacle!");
        }
    }

    public void AddCoin()
    {
        score++;
        coinText.text = "Score: " + score.ToString();
    }

}
