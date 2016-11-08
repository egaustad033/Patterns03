using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public bool up = false;
	public int speed;

	public GameObject sphere;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKey("up")){
				up = true;
				GetComponent<Rigidbody> ().velocity = transform.up * speed;
				Instantiate(sphere, new Vector3(60.5f, 28.0f, 45.5f), sphere.transform.rotation);
				Destroy (sphere.gameObject);
				sphere = null;
			}
			if (Input.GetKey("down")){
				up = false;
				GetComponent<Rigidbody> ().velocity = transform.up * -speed;
				Instantiate(sphere, new Vector3(60.5f, -21.0f, 45.5f), sphere.transform.rotation);
				Destroy (sphere.gameObject);
				sphere = null;
			}if (up == true){
				up = true;
				GetComponent<Rigidbody> ().velocity = transform.up * speed;
				Instantiate(sphere, new Vector3(60.5f, 28.0f, 45.5f), sphere.transform.rotation);
				Destroy (sphere.gameObject);
				sphere = null;
			}
			if (up == false){
				up = false;
				GetComponent<Rigidbody> ().velocity = transform.up * -speed;
				Instantiate(sphere, new Vector3(60.5f, -21.0f, 45.5f), sphere.transform.rotation);
				Destroy (sphere.gameObject);
				sphere = null;
			}
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Ball")
		{
			sphere = other.gameObject;
		}
	}
}
