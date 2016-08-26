using UnityEngine;
using System.Collections;

public class Gaze : MonoBehaviour {

    private CardboardHead head;
    private Rigidbody rb;
    public bool obismove = false;

    // Use this for initialization
    void Start () {

        Cardboard.SDK.OnTrigger += PullTrigger; //%%        
        head = GameObject.FindObjectOfType<CardboardHead>();
        rb = GetComponent<Rigidbody>();
    }

    public void PullTrigger()
    {
        if (obismove)
        {
            rb.velocity = head.Gaze.direction * 15;
        }
        else
        {
            rb.velocity = head.Gaze.direction *0;

        }
       
        
    }

    public Vector3 LookDirection()
    {
        return Vector3.ProjectOnPlane(head.Gaze.direction, Vector3.up);
    }
	// Update is called once per frame
	void Update () {
	
	}

}
