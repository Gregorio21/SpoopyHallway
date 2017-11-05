using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {
    private GameObject viewer;
    private GameObject cam;
    public int slowdown = 50;
	// Use this for initialization
	void Start () {
        viewer = GameObject.Find("Viewer");
        cam = GameObject.Find("CenterEyeAnchor");
	}
	
	// Update is called once per frame
	void Update () {
        //if not collision and forward pressed do this
        AudioSource x = viewer.GetComponent<AudioSource>();
        if(UnityEngine.Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            //viewer.GetComponent<Rigidbody>().AddForce(viewer.transform.forward*slowdown);
            viewer.GetComponent<Rigidbody>().velocity = new Vector3(cam.transform.forward.x * slowdown, 0, cam.transform.forward.z * slowdown);
            x.Play();
        }
        if (UnityEngine.Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            //viewer.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 0));
            viewer.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            if (x.isPlaying) x.Stop();
        }
        if (UnityEngine.Input.GetKey(KeyCode.Joystick1Button0))
        {
            if (!x.isPlaying) { x.Play(); }
        }
       
	}
}
