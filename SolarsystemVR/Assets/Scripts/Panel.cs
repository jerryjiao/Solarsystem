using UnityEngine;
using System.Collections;

public class Panel : MonoBehaviour {

    public Transform Target;

    public Vector2 TransformPosition(Vector3 position)
    {
        Vector3 offPosition = position - Target.position;
        Vector2 newPosition = new Vector2(offPosition.x, offPosition.z);
        return newPosition;

    }
}
