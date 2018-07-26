using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewdetails1 : MonoBehaviour {
    public Vector3 lastPosition;

    // Use this for initialization
    void Start() {
        lastPosition = transform.position;
    }

    public void LookAtBot() {
        if (lastPosition.z != -8) {
            lastPosition = new Vector3(lastPosition.x + 0.5f, lastPosition.y, lastPosition.z);
            transform.position = lastPosition;
        }
    }

	public void RemoveLookAtBot() {
        if (lastPosition.z != -8) {
            lastPosition = new Vector3(lastPosition.x - 0.5f, lastPosition.y, lastPosition.z);
            transform.position = lastPosition;
        }
    }
}
