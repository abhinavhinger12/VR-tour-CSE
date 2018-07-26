using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewdetails2 : MonoBehaviour {
    public Vector3 lastPosition;

    // Use this for initialization
    void Start() {
        lastPosition = transform.position;
    }

    public void LookAtBot2() {
        if (lastPosition.z != -8) {
            lastPosition = new Vector3(lastPosition.x , lastPosition.y, lastPosition.z - 1.5f);
            transform.position = lastPosition;
        }
    }

	public void RemoveLookAtBot2() {
        if (lastPosition.z != -8) {
            lastPosition = new Vector3(lastPosition.x , lastPosition.y, lastPosition.z + 1.5f);
            transform.position = lastPosition;
        }
    }
}
