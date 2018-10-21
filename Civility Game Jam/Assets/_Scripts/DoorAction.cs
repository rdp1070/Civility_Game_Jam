using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorAction : MonoBehaviour {
    public string otherScene;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            // Debug.Log("destroy");
            //Destroy(other.gameObject);
            SceneManager.LoadScene(otherScene, LoadSceneMode.Single);
        }
    }
}
