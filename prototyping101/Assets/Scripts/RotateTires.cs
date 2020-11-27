using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTires : MonoBehaviour
{

    public float tireSpeed = 75f;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        if (verticalInput > 0)
        {
            transform.Rotate(Vector3.right, Time.deltaTime * tireSpeed * verticalInput, Space.Self);
        }
        else if (verticalInput < 0)
        {
            transform.Rotate(Vector3.right, Time.deltaTime * tireSpeed * verticalInput, Space.Self);
        }
    }
}
