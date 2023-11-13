using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePLayerController : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float jumpForce;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
        }
        //// going forward
        //if (Input.GetKey(KeyCode.W))
        //{
        //    rigidbody.AddForce(Vector3.forward * movementSpeed * Time.deltaTime);
        //}
        //// going backwards
        //if (Input.GetKey(KeyCode.S))
        //{
        //    rigidbody.AddForce(Vector3.back * movementSpeed * Time.deltaTime);
        //}
        //// going left
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rigidbody.AddForce(Vector3.left * movementSpeed * Time.deltaTime);
        //}
        //// going right
        //if (Input.GetKey(KeyCode.D))
        //{
        //    rigidbody.AddForce(Vector3.right * movementSpeed * Time.deltaTime);
        //}
        // two players
        // one is on a super fast pc running at 250 fps
        // the other is on 10 fps
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * movementSpeed * Time.deltaTime);
    }
}
