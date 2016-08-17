using UnityEngine;
using System.Collections;

public class Blip : MonoBehaviour {

    public float Mapsize;

    public Transform Target;

    Panel panel;
    
    Transform myTransform;

    void Start()
    {
        panel = GetComponentInParent<Panel>();
        myTransform = GetComponent<Transform>();

    }

    void LateUpdate()
    {
        Vector2 newPosition = panel.TransformPosition(Target.position);

        myTransform.localPosition = newPosition*Mapsize;


    }
}
