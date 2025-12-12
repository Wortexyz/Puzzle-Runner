using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public Text text,winText;
    int score=0;
    public GameObject gameoverpannel,winPannel;
 
    private void OnCollisionEnter(Collision collision)
    {
      if ( collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            gameoverpannel.SetActive(true);
            score = 0;
        }
      else if ( collision.gameObject.tag == "Coin")
        {
            score++;
            text.text = "Score :" +score;
            Destroy(collision.gameObject);
        }
      else if ( collision.gameObject.tag == "Goal")
        {
            winPannel.SetActive(true);
            winText.text= "You Collected : " + score + "coins";
        }
    }
}
