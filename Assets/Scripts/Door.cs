using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public string scene;

    void OnCollisionEnter2D(Collision2D other) {
        if (string.Compare(other.gameObject.tag, "Player") == 0) {
            SceneManager.LoadScene(scene);
        }
    }

}
