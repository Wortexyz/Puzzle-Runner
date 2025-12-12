using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform Player;
    Vector3 playerPosition;
    [SerializeField] float Movespeed = 3f;
    // Start is called before the first frame update
    void Start()
    {

        playerPosition = Player.position;

    }

    // Update is called once per frame
    void Update()
    {
        moveToPlayer();
        
        Destroygameobject();
        
    }
    void moveToPlayer()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Movespeed * Time.deltaTime);
    }
    void Destroygameobject()
    {
        if (transform.position == playerPosition)
        {
           Destroy(gameObject);
        }
        
    }
}
