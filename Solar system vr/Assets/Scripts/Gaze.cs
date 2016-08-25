using UnityEngine;
using System.Collections;

public class Gaze : MonoBehaviour {

    private CardboardHead head;
    private Rigidbody rb;
    public bool obismove=false;


	// Use this for initialization
	void Start () {
        Cardboard.SDK.OnTrigger += PullTrigger;
        head = GameObject.FindObjectOfType<CardboardHead>();
        rb = GetComponent<Rigidbody>();
	}

    private void PullTrigger()
    {
        if (obismove)
        {
            rb.velocity = head.Gaze.direction * 10;
        }
        else
        {

            rb.velocity = new Vector3(0f, 0f, 0f);
        }

    }

    public Vector3 LookDirection()
    {
        return Vector3.ProjectOnPlane(head.Gaze.direction,Vector3.up);
    }

    // Update is called once per frame
    void Update () {
	
	}
   
}
