using UnityEngine;
using System.Collections;


public class ButtonFollow : MonoBehaviour {

    public Transform target;

      

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 newRotation = target.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(90f, newRotation.y*0.7f, 0f);
    }
}
