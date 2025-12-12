using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Dropper : MonoBehaviour
{
    [SerializeField] int constTime=3;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    private void Start()
    {
        myMeshRenderer=GetComponent<MeshRenderer>();
       myMeshRenderer.enabled=false;
        myRigidbody=GetComponent<Rigidbody>();
        myRigidbody.useGravity=false;
    }
    void Update()
    {
        if (Time.time > constTime)
        {
            myRigidbody.useGravity=true;
            myMeshRenderer.enabled = true;
           

        }
        
    }
}
