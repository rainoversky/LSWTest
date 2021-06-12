using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCreditsUI : MonoBehaviour {

    Text text;

    void OnEnable() {
        Player.OnCreditsChange += UpdateBalance;
    }

    void OnDisable() {
        Player.OnCreditsChange -= UpdateBalance;
    }

    void Start() {
        text = GetComponent<Text>();
        UpdateBalance();
    }

    void UpdateBalance() {
        text.text = Player.instance.credits.ToString() + " $";
    }

}
