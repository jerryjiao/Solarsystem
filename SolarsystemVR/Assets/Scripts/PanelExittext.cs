using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelExittext : MonoBehaviour {

    [SerializeField]
    private Text panelexittext = null;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeexitText() {
        string exitText = "Please Click the Planet";
        panelexittext.text = exitText;


    }
}
