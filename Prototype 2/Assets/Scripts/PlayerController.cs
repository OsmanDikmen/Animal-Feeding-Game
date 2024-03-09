using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Veriables for player controller
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;

    // Get preFabs for spawn our food
    public GameObject projectilePreFab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //food shuting key
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //launch projectile from player
            Instantiate(projectilePreFab, transform.position, projectilePreFab.transform.rotation);
        }

        // range for player movement
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Get horizontal axis value
        horizontalInput = Input.GetAxis("Horizontal");
        // Move horizontal direction
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
}
