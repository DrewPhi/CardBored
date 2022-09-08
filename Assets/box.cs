using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    // Start is called before the first frame update
    private bool state;
    private float distance;
    public Camera cam;
    private Vector3 initialPosition;
    public Rigidbody boxes;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
       
    }
    void OnMouseDown(){
      boxes.useGravity = false;
      this.transform.position = transform.position;
      this.transform.parent = cam.transform;

    }
    void OnMouseUp(){
        this.transform.parent = null;
        boxes.useGravity = true;
    }
}
