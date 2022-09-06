using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
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
             transform.localScale += new Vector3 (0.0F, .5F, 0.0F);

    }
    void OnMouseUp(){
             transform.localScale -= new Vector3 (0.0F, .5F, 0F);

    }
}
