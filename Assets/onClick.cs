using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour {
    public GameObject Box;
    private Vector3 BoxPos;
    private Vector3 temp;
    public GameObject SpawnPipe;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
    }
    
    void OnMouseDown() {
        transform.localScale -= new Vector3 (0.0F, .5F, 0.0F);
        temp = SpawnPipe.transform.position;
        Instantiate(Box, temp += new Vector3 (-2.5F,-5F,0F), Quaternion.Euler(BoxPos));
    }
    
    void OnMouseUp() {
        transform.localScale += new Vector3 (0.0F, .5F, 0F);
    }
}
