using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSen;
    public Transform PlayerBody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.gexAxis("Mouse X") * mouseSen * Time.deltaTime;
        float mouseY = Input.gexAxis("Mouse Y") * mouseSen * Time.deltaTime;

        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
