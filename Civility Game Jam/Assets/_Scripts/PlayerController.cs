using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;
    private bool onFloor;

    public float spawnTime;
    private float timer;

    public GameObject pusher;
    public GameObject startPoint;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        onFloor = true;

        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {

        float startX = startPoint.transform.position.x;
        float startY = startPoint.transform.position.y;

        timer += Time.deltaTime;
        // Debug.Log(timer);

        if (timer > spawnTime && ! GameObject.FindWithTag("Pusher")) {
            GameObject pusherClone = Instantiate(pusher, new Vector2(startX, startY), this.transform.rotation) as GameObject;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump(); 
        }

        if (Input.GetKey(KeyCode.A)) {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
    }

    private void Jump() {
        if (this.onFloor) {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            onFloor = false;
        }
    }

    private void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "Floor") {
            onFloor = true;
            // Debug.Log("onFloor");
        }
    }
}
