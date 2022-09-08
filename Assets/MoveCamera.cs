using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
    }
    public float minX = -60f;
	public float maxX = 60f;

	public float sensitivity;
	public Camera cam;

	float rotY = 0f;
	float rotX = 0f;
    

    void Update () {
        rotY += Input.GetAxis("Mouse X") * sensitivity;
		rotX += Input.GetAxis("Mouse Y") * sensitivity;
		rotX = Mathf.Clamp(rotX, minX, maxX);

		//cam.transform.localEulerAngles = new Vector3(0, rotY, 0);
		cam.transform.localEulerAngles = new Vector3(-rotX, rotY, 0);

		if (Input.GetKeyDown(KeyCode.Escape)){
        	//Mistake happened here vvvv
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}

		if (Cursor.visible && Input.GetMouseButtonDown(1))
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
	}
}
