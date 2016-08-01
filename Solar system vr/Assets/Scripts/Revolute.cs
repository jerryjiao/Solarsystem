using UnityEngine;
using System.Collections;

public class Revolute : MonoBehaviour {

    public float rotationSpeed = 30f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero,Vector3.up,rotationSpeed*Time.deltaTime);
	}
}
