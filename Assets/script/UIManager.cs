using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    player player_sc;
    manager manager_sc;
    public Text scoreText,hpText,timeText;
    
    // Start is called before the first frame update
    void Start()
    {
        manager_sc=GameObject.Find("Manager").GetComponent<manager>();
        player_sc=FindObjectOfType<player>();
      InvokeRepeating("dataToUI",1f,.1f);
    }
    void dataToUI(){
       scoreText.text="Score: "+manager_sc.score.ToString();
       timeText.text = (((int)manager_sc.timeLeft - (int)Time.time)).ToString();
       hpText.text=player_sc.hp.ToString();       
    }
    // Update is called once per frame
    void Update()
    {
          
    }
}
