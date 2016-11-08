using UnityEngine;
using System.Collections;

public class Launch : MonoBehaviour {

	public float varLaunch;

	private void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Ball") {
			//adds force
			other.transform.GetComponent<Rigidbody> ().AddForce (this.transform.up * varLaunch);
		}
	}
}
