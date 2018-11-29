using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrdPersonCam : MonoBehaviour {

    private const float YANGLEMAX = 0.0f;
    private const float YANGLEMIN = 50.0f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 400.0f;
    private float sensitivityY = 400.0f;
    // Use this for initialization
    private  void Start() {
        camTransform = transform;
        cam = Camera.main;
	}
	
	// Update is called once per frame
	private void Update () {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");
        currentY += Mathf.Clamp(currentY, YANGLEMIN, YANGLEMAX);
	}

    public void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }

}
