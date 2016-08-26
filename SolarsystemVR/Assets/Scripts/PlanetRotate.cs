using UnityEngine;
using System.Collections;

public class PlanetRotate : MonoBehaviour {

    public float rotatespeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(0, rotatespeed, 0) * transform.rotation;
	}
}
