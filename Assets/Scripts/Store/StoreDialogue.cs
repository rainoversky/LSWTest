using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreDialogue : MonoBehaviour {

    float timeCounter;

    void OnEnable() {
        timeCounter = 5;
    }

    void Start() {

    }

    void Update() {
        if (timeCounter > 0) {
            timeCounter -= Time.deltaTime;
        } else {
            gameObject.SetActive(false);
        }
    }

}
