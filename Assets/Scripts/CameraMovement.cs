using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float movementSpeed = 1.0f;
    public float rotationSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            transform.eulerAngles += rotationSpeed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.position += -transform.right * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.position += transform.right * Time.deltaTime * movementSpeed;
        } 
        
        if (Input.GetKey(KeyCode.W)) {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.position += -transform.forward * Time.deltaTime * movementSpeed;
        }
        
        if (Input.GetKey(KeyCode.LeftShift)) {
            transform.position += Vector3.down * Time.deltaTime * movementSpeed;
        }
        
        if (Input.GetKey(KeyCode.Space)) {
            transform.position += Vector3.up * Time.deltaTime * movementSpeed;
        }
    }
}
