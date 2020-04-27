using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowMarker : MonoBehaviour
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
      if (collision.gameObject.tag == "Y_Corner")
      {
         Debug.Log("Enter Yellow Corner!");
         i = 1;
      }
    }
}
