using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public int score;
    public float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        score=0;
        timeLeft=60;
    }

    // Update is called once per frame
    void Update()
    {
        //timeLeft-=Time.time;
        if(timeLeft<=0){
         
        }
    }
}
