using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ClothingSlotUI : MonoBehaviour {

    public Image image;

    void OnEnable() {
        Clothes.ClothingChange += UpdateSlot;
        if (Player.instance != null) UpdateSlot();
    }

    void OnDisable() {
        Clothes.ClothingChange -= UpdateSlot;
    }

    public abstract void UpdateSlot();

}
