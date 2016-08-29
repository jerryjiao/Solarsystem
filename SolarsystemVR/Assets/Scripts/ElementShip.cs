using UnityEngine;
using System.Collections;

public class ElementShip : MonoBehaviour {

    public float Mapsize;

    public Transform Target;
    
    Panel panel;

    Transform elementtransform;

    //private CardboardHead head;


    
    // Use this for initialization
    void Start () {
        panel = GetComponentInParent<Panel>();
        elementtransform = GetComponent<Transform>();
        //head = GameObject.FindObjectOfType<CardboardHead>();
    }
	
	// Update is called once per frame
	void LateUpdate () {
        Vector2 newPosition = panel.TransformPosition(Target.position);
        elementtransform.localPosition = newPosition * Mapsize;
       
        //string information = Target.rotation.ToString();
        //Debug.Log(information);
        Vector3 newRotation = Target.rotation.eulerAngles;
        //elementtransform.Rotate(0f, newRotation.y*0.0005f, 0f);
        elementtransform.rotation = Quaternion.Euler(0f,newRotation.y,180f);
    }
}
