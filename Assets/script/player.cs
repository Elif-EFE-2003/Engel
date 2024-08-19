using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    Rigidbody rb;
    public int hp;
    float moveSpeed;
    public Vector3 moveDirecton,moveNormal;
    public float moveVector,normalVector;
    public int score;
    public float sensivity,jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        hp=100;
        rb=gameObject.GetComponent<Rigidbody>();
        moveSpeed=5;
        score=0;
    }

    // Update is called once per frame
    void Update()
    {
        moveDirecton=new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        // moveVector=moveDirecton.magnitude; farkı görebilmek için
        moveDirecton.Normalize();
        //normalVector=moveDirecton.magnitude; farkı görebilmek için
        transform.Translate(moveDirecton*Time.deltaTime*moveSpeed);
        transform.Rotate(0,Input.GetAxis("Mouse X")*sensivity*Time.deltaTime,0);
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);

        }
    }
    private void  OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="collectable"){

                Destroy(other.gameObject);
                score+=10;
        }
    }
}
