using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneSwitcher : MonoBehaviour
{   
    public string WinScene;
    int j = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       j = BlueMarker.i + YellowMarker.i + RedMarker.i + GreenMarker.i;

       if (j == 4)
       {
         SceneManager.LoadScene(WinScene);
         BlueMarker.i = 0;
         YellowMarker.i = 0;
         RedMarker.i = 0;
         GreenMarker.i = 0;
       }
    }
}
