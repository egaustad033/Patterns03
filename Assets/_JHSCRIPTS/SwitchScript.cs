using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour {

    GameObject jh;
    int i = 0;
    Vector3 jp, jp2;

    // Use this for initialization
    void Start () {
        jh = GameObject.Find ("Jw");
        jp = jh.transform.position;
        jp2 = new Vector3(jh.transform.position.x, jh.transform.position.y + 4, jh.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (i == 0)
            {
                jh.transform.position = jp2;
                i++;
            }
            else
            {
                    jh.transform.position = jp;
                    i--;
            }
        }
    }

    /*
    void OnMouseDown()

    {
        if (i == 0)
        {
            jh.transform.position = jp2;
            i++;
        }
        else
        {
            jh.transform.position = jp;
            i--;
        }

    }
    */
    
}
