using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float rotationSpeed = 3f;
    public Camera tpCamera;

    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>(); ;
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + transform.TransformDirection(movement));

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up, mouseX * rotationSpeed);
        tpCamera.transform.Rotate(Vector3.right, -mouseY * rotationSpeed);

    }
}
