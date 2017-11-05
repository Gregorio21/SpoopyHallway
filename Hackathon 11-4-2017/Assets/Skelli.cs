using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelli : MonoBehaviour {
    private GameObject skelly;
    // Use this for initialization
    void Start () {
        skelly = GameObject.Find("activateSkellyNoise");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        
    }
}
