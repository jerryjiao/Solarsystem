using UnityEngine;
using System.Collections;

public class MovetoSun : MonoBehaviour {

    public Transform target;

    MoveCardboard mc;

    // Use this for initialization
    void Start()
    {
        mc = GameObject.FindObjectOfType<MoveCardboard>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {
        Vector3 newPosition = target.position;
        newPosition.y += 200f;
        newPosition.z -= 500f;
        mc.moveCard(newPosition);

    }
}
