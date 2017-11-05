using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour {
    public GameObject go;
    private GameObject skelly;
    private GameObject HornBox;
    private GameObject TenBox;
    
	// Use this for initialization
	void Start () {
        go = GameObject.Find("skeleton");
        skelly = GameObject.Find("activateSkellyNoise");
        HornBox = GameObject.Find("HornBox");
        TenBox = GameObject.Find("TenBox");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("jump"))
        {
            //Debug.Log("sound");
            go.GetComponent<Animation>().Play();
            go.GetComponent<AudioSource>().Play();
            GameObject.Find("TenBox").GetComponent<AudioSource>().Stop();
        }
        else if (other.gameObject.CompareTag("Trigger"))
        {
          //  Debug.Log("sound");
            skelly.GetComponent<AudioSource>().Play();
        }
        else if (other.gameObject.CompareTag("Horns"))
        {
          //  Debug.Log("sound");
            HornBox.GetComponent<AudioSource>().Play();
        }
        else if (other.gameObject.CompareTag("tENTION"))
        {
          //  Debug.Log("sound");
            TenBox.GetComponent<AudioSource>().Play();
            
        }
        else if (other.gameObject.CompareTag("end"))
        {
            this.transform.position.Set(-4.468f, -4.235f, -3.199f);
        }
    }
}

