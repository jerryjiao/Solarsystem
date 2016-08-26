using UnityEngine;
using System.Collections;


public class CalculateDistance : MonoBehaviour {

    public Transform cameraposition;
    public Transform target2;
    public Transform target3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 origin = new Vector3(0f, 0f, 0f);
        var distance = Vector3.Distance(cameraposition.transform.position, origin);
        var userhigh = cameraposition.position.y;
        var test = Mathf.Abs(distance * distance - userhigh * userhigh);
        var distance1 = Mathf.Sqrt(test);
        Debug.Log(distance1);
        //Debug.Log("second"+userhigh);
        //Debug.Log("Third"+test);
       
    }
}
