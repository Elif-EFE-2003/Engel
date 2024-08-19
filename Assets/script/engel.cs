using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,moveSpeed*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Finish"){
            transform.position=new Vector3(transform.position.x,1,50);
        }
    }
}
