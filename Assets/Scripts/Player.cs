using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Clothes clothes;
    public static Player instance;

    void Start() {
        instance = this;
    }

    void Update() {

    }

}
