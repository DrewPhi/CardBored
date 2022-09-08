using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    private string lastState = "backward";
    // Start is called before the first frame update
    void Start()
    {
        transform.localRotation = Quaternion.Euler(-90, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown(){
            
            if (transform.localRotation ==  Quaternion.Euler(-90, 0, 0)){
                if (lastState == "forward"){
                    transform.localRotation = Quaternion.Euler(-135, 0, 0);

                }
                else if(lastState == "backward"){
                    transform.localRotation =  Quaternion.Euler(-45, 0, 0);
                }



            }
            else if(transform.localRotation ==  Quaternion.Euler(-45, 0, 0)){
                transform.localRotation = Quaternion.Euler(-90, 0, 0);
                lastState="forward";
            }
            else{
                transform.localRotation = Quaternion.Euler(-90, 0, 0);
                lastState="backward";


            }


    }
    void OnMouseUp(){

    }
}
