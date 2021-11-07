using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target;
    public Camera cam;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float planoDeCorte = 0.3f;

    void Start()
        {
            // Use GetComponent to access the camera
            Camera cam = gameObject.GetComponent<Camera>();
        
        }

    // Update is called once per frame
    void FixedUpdate()
    {
        cam.nearClipPlane = planoDeCorte;
        Vector3 posicionDeseada = target.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, posicionDeseada, smoothSpeed*Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(target);
        
    }
}
