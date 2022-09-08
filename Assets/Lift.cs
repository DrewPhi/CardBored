using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public GameObject Lever;
    public Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frames
    void Update()
    {
        if (Lever.transform.eulerAngles ==  new Vector3(315, 180, 180) && transform.localPosition.y > 3){
                                 rig.MovePosition(transform.position - new Vector3(0.01F,0));

            }
            else if(Lever.transform.eulerAngles == new Vector3(315, 0, 0)){
                                 rig.MovePosition(transform.position + new Vector3(0.01F,0));

            }


            }

    }
