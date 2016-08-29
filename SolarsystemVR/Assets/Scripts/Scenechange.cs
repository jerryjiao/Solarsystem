using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Scenechange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadLevel() {
        SceneManager.LoadScene("SolarSystemmain");
    }

    public void LoadLevel2() {
        SceneManager.LoadScene("RealScaleScene");

    }
}
