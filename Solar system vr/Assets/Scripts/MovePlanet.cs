using UnityEngine;
using System.Collections;

public class MovePlanet : MonoBehaviour
{

    public Transform target;

    MoveCardboard ch;
    // Use this for initialization
    void Start()
    {
        ch = GameObject.FindObjectOfType<MoveCardboard>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
        Vector3 new1 = target.position;
        new1.z -= 100f;
        ch.movecard(new1);
    }
}