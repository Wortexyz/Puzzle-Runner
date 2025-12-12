using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("SomethingHitME");
            GetComponent<MeshRenderer>().material.color = Color.black;
            if (gameObject.tag != "Obstacle" && gameObject.tag != "Wall")
            {
                gameObject.tag = "Hit";
            }
        }
    }
}
