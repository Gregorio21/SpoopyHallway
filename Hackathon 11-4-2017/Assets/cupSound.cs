using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Hull") && !other.GetComponent<AudioSource>().isPlaying)
        {
            other.GetComponent<AudioSource>().Play();
        }
        else if (other.gameObject.CompareTag("Mug") && !other.GetComponent<AudioSource>().isPlaying)
        {
            other.GetComponent<AudioSource>().Play();
        }
    }
    }
