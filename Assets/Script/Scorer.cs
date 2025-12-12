using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public Text text,winText;
    int score=0;
    public GameObject winPannel;
    public  GameObject Startposition;

    private void Awake()
    {
        winPannel.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
      if ( collision.gameObject.tag == "Obstacle")
        {
            
           gameObject.transform.position = Startposition.transform.position;
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
