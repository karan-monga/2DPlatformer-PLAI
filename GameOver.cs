using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.name == "Player")
            Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
