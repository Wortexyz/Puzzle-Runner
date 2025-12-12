using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTrigger : MonoBehaviour
{
    [SerializeField] GameObject[] projectile;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (GameObject p in projectile)
        {
            p.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    
    {
        if (other.gameObject.tag == "Player")
        {
            foreach (GameObject p in projectile)
                p.SetActive(true);
        }
    }
}
