using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yvalue = 0f;
        float zvalue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime ;

        transform.Translate(xValue,yvalue,zvalue);   
    }
}
