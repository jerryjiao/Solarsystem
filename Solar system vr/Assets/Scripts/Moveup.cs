using UnityEngine;
using System.Collections;

public class Moveup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MoveUp()
    {
        transform.position += new Vector3(0f, 10f, 0f);

    }
}
