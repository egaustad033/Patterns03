using UnityEngine;
using System.Collections;

public class BoostScript : MonoBehaviour {
    public float xforce, yforce, zforce = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider c)
    {
        Rigidbody rb = c.GetComponent<Rigidbody> ();
        rb.AddForce(xforce,yforce,zforce);

    }

}
