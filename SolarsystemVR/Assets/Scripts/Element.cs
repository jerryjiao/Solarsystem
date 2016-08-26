using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour {

    public float Mapsize;

    public Transform Target;

    Panel panel;

    Transform elementtransform;

	// Use this for initialization
	void Start () {
        panel = GetComponentInParent<Panel>();
        elementtransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void LateUpdate () {
        Vector2 newPosition = panel.TransformPosition(Target.position);
        elementtransform.localPosition = newPosition * Mapsize;
	}
}
