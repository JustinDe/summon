﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BookInteractions : MonoBehaviour {
    private SpriteRenderer spriteRenderer; 
    public GenericObjController goc;
    public Sprite defaultSprite;
    public Sprite activeSprite;
    
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        if (spriteRenderer.sprite == null) 
            spriteRenderer.sprite = defaultSprite; 
    }
    void Update() {
        // Top Trigger on Utopia 360 Controller on PC = 7 Android = 5 (Interact)
        if (Input.GetKeyDown(KeyCode.JoystickButton7) == true || Input.GetKeyDown(KeyCode.JoystickButton5) == true || Input.GetMouseButtonDown(0)) {
            if (goc.lookCheck() == true) {
                Debug.Log("Interacted with " + gameObject.name);
                toggleSprite();
            }
        }

        // Bottom Trigger on Utopia 360 Controller on PC = 6 Android = 4 (Pickup) ((Not currently used since pickup is handled with other script))
        //if (Input.GetKeyDown(KeyCode.JoystickButton6) == true || Input.GetKeyDown(KeyCode.JoystickButton4) == true) {
        //    if (goc.lookCheck() == true) {
        //        Debug.Log("Picked up " + gameObject.name);
        //    }
        //}
    }

    void toggleSprite() {
        if (spriteRenderer.sprite == defaultSprite) {
            spriteRenderer.sprite = activeSprite;
        }

        else {
            spriteRenderer.sprite = defaultSprite; // otherwise change it back to defaultSprite
        }
    }
}
