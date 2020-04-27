using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text MainTimer; 

    double secValue = 60;

    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("Player Has Been Initiated");
      Debug.Log("Countdown Timer Has Begun");        
    }

    // Update is called once per frame
    void Update()
    {
       secValue -= Time.deltaTime;
       float wholeSecValue = (float)System.Math.Round(secValue, 1);
       MainTimer.text = wholeSecValue.ToString();    

       if (secValue <= 0.0)
       {
           secValue = 0.0;
           MainTimer.text = secValue.ToString();
           System.Math.Round(secValue, 2);
           SceneManager.LoadScene("LoseScene");
       }    
    }
}
