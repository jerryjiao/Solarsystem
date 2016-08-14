using UnityEngine;
using System.Collections;

public class MenuFollow : MonoBehaviour {

    public float Distance = 5.0f;

    public float Height = 1.0f;

    private Gaze gaze;

	// Use this for initialization
	void Start () {
        gaze = GameObject.FindObjectOfType<Gaze>();
        transform.Rotate(Vector3.up);
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.rotation = Quaternion.LookRotation(gaze.LookDirection());
        transform.position = gaze.transform.position;
        transform.position += gaze.LookDirection() * Distance;
        transform.position += Vector3.up * Height;
	}
}
