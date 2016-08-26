using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonTxtedit : MonoBehaviour {

    [SerializeField]
    private Text nerds = null;
    private Gaze gz;

	// Use this for initialization
	void Start () {
        gz = GameObject.FindObjectOfType<Gaze>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changetext() {
        if (gz.obismove)
        { nerds.text = "Travel Model:On"; }
        else
        { nerds.text = "Travel Model:Off"; }
        

    }
}
