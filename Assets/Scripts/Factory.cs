using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

	public GameObject observer; //incoming objects
	public Vector3 spawnValues; //range of values to spawn
	public double Timer;

	// Update is called once per frame
	void Update () {
		Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;



		if (Timer < Time.time) {
			//Instantiate (observer, spawnPosition, spawnRotation);
			Object o = Instantiate (observer, spawnPosition, spawnRotation);
			GameObject go = (GameObject)o;


			Timer = Time.time + 3f;
		}

	}

	void Awake()
	{
		Timer = Time.time + 3f;
	}

}