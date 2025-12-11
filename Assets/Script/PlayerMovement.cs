using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float xValue=5f;
    public float yvalue = 5f;
    public float zvalue = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(xValue,yvalue,zvalue);   
    }
}
