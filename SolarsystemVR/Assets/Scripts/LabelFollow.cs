using UnityEngine;
using System.Collections;

public class LabelFollow : MonoBehaviour {

    private Gaze gaze;

    // Use this for initialization
    void Start () {
        gaze = GameObject.FindObjectOfType<Gaze>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.LookRotation(gaze.LookDirection());
    }
}
