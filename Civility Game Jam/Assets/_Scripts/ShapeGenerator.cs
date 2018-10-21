using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour {

    public Sprite sprite;
    public SpriteRenderer spriteRenderer;
    public ShapeChunkController[] shapeChunks;

    /// <summary>
    /// how many times we are cutting the sprite
    /// </summary>
    public float resolution;


	// Use this for initialization
	void Start () {
        Initialize();
	}

    private void Initialize()
    {
        // at the beginning you need to determine which prefab of shapes you are and then make the
        // triangles that fit inside of it.

        shapeChunks = GetComponents<ShapeChunkController>();
       
    }

}
