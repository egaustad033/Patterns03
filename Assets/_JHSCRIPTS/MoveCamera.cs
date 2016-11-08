using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
    public float hSpeed = 2.0f;
    public float vSpeed = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
        float xAxisVal = Input.GetAxis("Horizontal");
        float zAxisVal = Input.GetAxis("Vertical");
        if (Camera.current != null){
            Camera.current.transform.Translate(new Vector3(xAxisVal, 0.0f, zAxisVal));
        }
        yaw += hSpeed * Input.GetAxis("Mouse X");
        pitch -= vSpeed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
