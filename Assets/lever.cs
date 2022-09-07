using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown(){
            if (transform.localRotation ==  Quaternion.Euler(-90, 0, 0)){
                transform.localRotation = Quaternion.Euler(-45, 0, 0);


            }
            else if(transform.localRotation ==  Quaternion.Euler(-45, 0, 0)){
                transform.localRotation = Quaternion.Euler(-135, 0, 0);

            }
            else{
                transform.localRotation = Quaternion.Euler(-90, 0, 0);


            }


    }
    void OnMouseUp(){

    }
}
