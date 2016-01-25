using UnityEngine;
using System.Collections;

public class Script : MonoBehaviour {

    // Use this for initialization
    public Vector3 targetpos = Vector3.zero;

    bool on = false;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("space"))
        { on = true;  }

        if (Input.GetKeyUp("space"))
        { on = false; }

        if (on == true)
        {
            stuff();
        }

    }

    void stuff()
    {
        Vector3 a = transform.position;
        transform.position += targetpos - a * 0.000000002f * Time.deltaTime;
    }

}
 