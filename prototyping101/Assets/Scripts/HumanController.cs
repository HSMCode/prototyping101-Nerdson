using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    private Rigidbody _humanRb;
    public float jumpForce = 10f;
    public float gravityModifier;

    // Start is called before the first frame update
    void Start()
    {
        _humanRb = GetComponent<Rigidbody>();
        Physics.gravity = Physics.gravity * gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            _humanRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
