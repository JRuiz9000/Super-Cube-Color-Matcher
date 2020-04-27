using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(-7, 12);
        y = 30;
        z = Random.Range(-7, 9);
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
