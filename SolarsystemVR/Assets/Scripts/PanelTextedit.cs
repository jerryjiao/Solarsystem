using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelTextedit : MonoBehaviour {

    [SerializeField]
    private Text paneltext = null;
    

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeText(string Planetname)
    {
        paneltext.text = Planetname;

    }
}
