using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public GameObject SecondPlatform;

	private void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Ball") {
			//find other's Vector3 difference to the platform
			Vector3 difference = other.transform.position - transform.parent.position;

			//find where other's location will be in relation to second platform
			Vector3 newLoc = difference + SecondPlatform.transform.position;

			//reassign other's location
			other.transform.position = newLoc;
		}
	}
}