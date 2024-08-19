using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trambolin : MonoBehaviour
{
    Rigidbody rb;
    public float trambolinForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player"){
           other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*trambolinForce,ForceMode.Impulse);
        }
    }
}
