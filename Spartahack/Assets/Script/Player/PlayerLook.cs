using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation =0f;

    public float Sensitivity=1000f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX=Input.GetAxis("Mouse X")* Sensitivity* Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y")* Sensitivity* Time.deltaTime;
        //calculate camera rotation
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-80,80f);

        //apply this to our camera transform
        cam.transform.localRotation= Quaternion.Euler(xRotation,0,0);
        //rotate player to look left and right
        transform.Rotate(Vector3.up * mouseX);
    }

}
