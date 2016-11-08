using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float xf, yf, zf = 0;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {}

	// Update is called once per frame
	void Update () {}

	void OnTriggerStay( Collider c ){
	 	rb = c.GetComponent<Rigidbody>();
		rb.AddForce (xf, yf, zf);

	}
}
