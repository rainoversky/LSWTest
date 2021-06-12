using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopkeeper : MonoBehaviour {

    void Start() {

    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.GetComponent<Player>() != null) {
            UIManager.OnNearToVendor?.Invoke();
        }
    }

    void OpenDialogue() {

    }

}
