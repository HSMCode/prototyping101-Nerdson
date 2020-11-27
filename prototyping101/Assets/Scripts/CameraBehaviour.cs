using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public GameObject car;
    public float CarX;
    public float CarY;
    public float CarZ;

    // offset from local point of car to camera position
   //private Vector3 offset = new Vector3(0, 5, -8); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = car.transform.position + offset;

        CarX = car.transform.eulerAngles.x;
        CarY = car.transform.eulerAngles.y;
        CarZ = car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
    }
}
