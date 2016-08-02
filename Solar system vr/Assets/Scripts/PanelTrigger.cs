using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelTrigge : MonoBehaviour {

    private Button btn;

    private CardboardHead ButtonHead;

	// Use this for initialization
	void Start () {
        Cardboard.SDK.OnTrigger += SDK_OnTrigger;
        ButtonHead = GameObject.FindObjectOfType<CardboardHead>();
	}

    private void SDK_OnTrigger()
    {
        print("Button Click!");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
