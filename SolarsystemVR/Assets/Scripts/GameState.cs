using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

    private Gaze gz;

	// Use this for initialization
	void Start () {
        gz = GameObject.FindObjectOfType<Gaze>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changestate() {
        gz.obismove = !gz.obismove;
        gz.PullTrigger();
    }
}
