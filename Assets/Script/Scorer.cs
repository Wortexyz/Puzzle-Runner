using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public Text text;
    int score=0;
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            score--;
            Debug.Log("I hitted on the WALL and my score = " +score);
            text.text = "Score :" + score;
        }
        if (collision.gameObject.tag == "Obstacle")
        {            
            score++;
            Debug.Log("I Hitted on the OBSTACLE  and my score = " +score);
            text.text ="Score :"+score;
        }
    }
}
