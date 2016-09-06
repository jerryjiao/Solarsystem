using UnityEngine;
using System.Collections;

public class Revolute : MonoBehaviour {

    public float rotateSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 origin = new Vector3(0, 0, 0); //define the point that the planet rotate
        transform.RotateAround(origin,Vector3.up,rotateSpeed*Time.deltaTime);
	}
}
