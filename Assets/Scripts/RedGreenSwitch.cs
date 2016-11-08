using UnityEngine;
using System.Collections;

public class RedGreenSwitch : MonoBehaviour {

	GameObject x;
	int i = 0;
	Vector3 wp, wp2;

	// Use this for initialization
	void Start () {
		x = GameObject.Find ("Wall1");
		wp = x.transform.position;
		wp2 = new Vector3 (x.transform.position.x, x.transform.position.y + 4, x.transform.position.z); 
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown ("space")) {
			if (i == 0) {
				x.transform.position = wp2;
				i++;
			} else {
				x.transform.position = wp;
				i--;
			}
		}
	}

	void OnMouseDown() {
		if (i == 0) {
			x.transform.position = wp2;
			i++;
		} else {
			x.transform.position = wp;
			i--;
		}
			
	}
}
	
