using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAction : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pusher") {
            // Debug.Log("destroy");
            Destroy(other.gameObject);
        }
    }
}
