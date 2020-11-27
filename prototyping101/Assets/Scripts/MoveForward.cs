using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 100f;
    private Rigidbody _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    /* Update is called once per frame
    void Update()
    {
        _playerRb.AddForce(Vector3.forward * speed * Time.fixedDeltaTime);

        transform.Translate(Vector3.forward * Time.deltaTime * speed); 
    } */

    private void FixedUpdate()
    {
        _playerRb.AddForce(Vector3.forward * speed * Time.fixedDeltaTime);
    }

}
