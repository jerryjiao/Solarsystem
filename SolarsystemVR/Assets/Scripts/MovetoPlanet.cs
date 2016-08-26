using UnityEngine;
using System.Collections;

public class MovetoPlanet : MonoBehaviour {

    public Transform target;

    MoveCardboard mc;

	// Use this for initialization
	void Start () {
        mc = GameObject.FindObjectOfType<MoveCardboard>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Click()
    {
        Vector3 newPosition = target.position;
        newPosition.z -= 100f;
        mc.moveCard(newPosition);

    }
}
