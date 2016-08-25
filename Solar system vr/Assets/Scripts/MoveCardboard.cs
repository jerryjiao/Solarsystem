using UnityEngine;
using System.Collections;

public class MoveCardboard : MonoBehaviour {

    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }
   
    public void movecard(Vector3 target1) {

        rb.transform.position = target1;
    }
}
