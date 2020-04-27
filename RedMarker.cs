using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMarker : MonoBehaviour
{
    public static int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
      if (collision.gameObject.tag == "R_Corner")
      {
         Debug.Log("Enter Red Corner!");
         i = 1;
      }
    }
}
