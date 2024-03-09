using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topRange = 30;
    private float lowerRange = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topRange)
        {
            Destroy(gameObject);
        }else if(transform.position.z < lowerRange)
        {
            Destroy(gameObject);
        }
    }
}
