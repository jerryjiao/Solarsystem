using UnityEngine;
using System.Collections;

public class ShowNameonPanel : MonoBehaviour {

    PanelTextedit pte;
    public Transform TargetPlanet;

	// Use this for initialization
	void Start () {
        pte = GameObject.FindObjectOfType<PanelTextedit>();
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Changetext() {
        string Planetname = TargetPlanet.name;
        pte.ChangeText(Planetname);
    }
}
