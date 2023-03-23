using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestoryOutofBounds : MonoBehaviour
{

    private float topBound = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {

            Destory(gameObject);
        }
        else if (transform.position.z < lowerBound)

            Destory(gameObject);
    }
}
