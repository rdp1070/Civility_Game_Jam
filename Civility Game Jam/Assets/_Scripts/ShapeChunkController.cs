using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChunkController : MonoBehaviour {

    public BoxCollider2D Box;
    public SpriteMask SpriteMask;
    public bool isChipped;

    public void SwitchOff() {
        SpriteMask.enabled = true;
        Box.enabled = false;
        isChipped = true;
    }
    
      public void SwitchOn()
    {
        SpriteMask.enabled = false;
        Box.enabled = true;
        isChipped = false;
    }

}
