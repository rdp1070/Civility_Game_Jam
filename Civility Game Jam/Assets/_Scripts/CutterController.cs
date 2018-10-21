using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterController : MonoBehaviour {

    private bool mousePressed;
    Vector2 mouseStartPos;

	// Use this for initialization
	void Start () {
        mousePressed = false;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0)) {

            if (!mousePressed) {
                mouseStartPos = currentMousePos;
            }
            Debug.DrawLine(mouseStartPos, currentMousePos, Color.red);
            // Debug.Log(currentMousePos);
            mousePressed = true;

        }
        else if (mousePressed){
            
            mousePressed = false;
        }
	}
}
