using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float rotX,rotY,rotZ;
    // Start is called before the first frame update
    void Start()
    {
        rotX=Random.Range(0,20)*0.01f;
        rotY=Random.Range(0,100)*0.01f;
        rotZ=Random.Range(0,20)*0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotX,rotY,rotZ);
    }
    //void OnTriggerEnter(Collider other){Destroy(gameObject);} kendini yok eder
    
}
