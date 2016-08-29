using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceText : MonoBehaviour {

   
    public Text distancetext = null;

    CalculateDistance cald;

    // Use this for initialization
    void Start () {
        cald = GameObject.FindObjectOfType<CalculateDistance>();
	}
	
	// Update is called once per frame
	void Update () {
        float distance = cald.getdisdance();

        if (distance > 0 && distance < 500)
        {
            distancetext.text = "You are between Sun and Mercury";

        }
        else if (distance > 500 && distance < 600)
        {
            distancetext.text = "You are between Mercury and Venus";


        }
        else if (distance > 600 && distance < 800)
        {
            distancetext.text = "You are between Venus and Earth";


        }
        else if (distance > 800 && distance < 980)
        {
            distancetext.text = "You are between Earth and Mars";

        }
        else if (distance > 980 && distance < 1192)
        {
            distancetext.text = "You are between Mars and Jupiter";
        }
        else if (distance > 1192 && distance < 1819)
        {
            distancetext.text = "You are between Jupiter and Saturn";
        }
        else if (distance > 1819 && distance < 2389)
        {
            distancetext.text = "You are between Saturn and Uranus";
        }
        else if (distance > 2389 && distance < 2780)
        {
            distancetext.text = "You are between Uranus and Neptune";
        }
    }
}
