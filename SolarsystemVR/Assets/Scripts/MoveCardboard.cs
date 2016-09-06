using UnityEngine;
using System.Collections;

public class MoveCardboard : MonoBehaviour {

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    public void moveCard(Vector3 target) {
        //This function use main camera Rigidbody to move main camera
        rb.transform.position = target;

    }
}
