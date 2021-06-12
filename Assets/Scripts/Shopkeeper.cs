using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopkeeper : MonoBehaviour {

    void Start() {

    }

    void Update() {

    }

    void OnCollisionEnter2D(Collision2D other) {
        if (string.Compare(other.gameObject.tag, "Player") == 0) {
            OpenDialogue();
        }
    }

    void OpenDialogue() {
                
    }

}
