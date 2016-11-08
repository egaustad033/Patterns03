using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {
    public Rigidbody rb;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	//}
	
	// Update is called once per frame
	//void Update () {

        Vector3 movemenet = new Vector3(0.0f, 0.0f, 100.0f);

        //rb.AddForce(transform.forward * 100.0f);
        rb.AddForce(movemenet * speed);
	}
}
