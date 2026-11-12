using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("HelloWorld");
        horizontalInput = Input.GetAxis("Horizontal");
        //   transform.position = new Vector3(-10, 3, 12);
        transform.Translate(Vector3.forward * speed*Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * rotationSpeed*Time.deltaTime * horizontalInput);
    }
}
