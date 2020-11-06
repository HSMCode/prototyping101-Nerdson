using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 25; // Speed for our hot red vehicle


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move our hot red vehicle
        transform.Translate( translation: Vector3.forward * Time.deltaTime * speed);
    }
}
