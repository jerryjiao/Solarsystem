using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CalculateDistanceReal : MonoBehaviour {

    public Text distancetext = null;

    CalculateDistance cald;

    // Use this for initialization
    void Start()
    {
        cald = GameObject.FindObjectOfType<CalculateDistance>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = cald.getdisdance();

        if (distance > 0 && distance < 117)
        {
            distancetext.text = "You are between Sun and Mercury";

        }
        else if (distance > 117 && distance < 216)
        {
            distancetext.text = "You are between Mercury and Venus";


        }
        else if (distance > 216 && distance < 300)
        {
            distancetext.text = "You are between Venus and Earth";


        }
        else if (distance > 300 && distance < 450)
        {
            distancetext.text = "You are between Earth and Mars";

        }
        else if (distance > 450 && distance < 1560)
        {
            distancetext.text = "You are between Mars and Jupiter";
        }
        else if (distance > 1560 && distance < 2850)
        {
            distancetext.text = "You are between Jupiter and Saturn";
        }
        else if (distance > 2850 && distance < 5670)
        {
            distancetext.text = "You are between Saturn and Uranus";
        }
        else if (distance > 5670 && distance < 9000)
        {
            distancetext.text = "You are between Uranus and Neptune";
        }
    }
}
