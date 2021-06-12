using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject clothesPanel;

    void Awake() {
        clothesPanel.SetActive(false);
    }

    void Start() {

    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Z)) {
            clothesPanel.SetActive(!clothesPanel.activeInHierarchy);
        }
    }
}
