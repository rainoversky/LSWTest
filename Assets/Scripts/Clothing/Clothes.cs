using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/Clothes")]
public class Clothes : ScriptableObject {

    public static Action ClothingChange;
    public ClothingSlot shawl;
    public ClothingSlot brazalet;
    public ClothingSlot glove;
    public ClothingSlot belt;
    public ClothingSlot boots;

    Clothes() {
        shawl = new ClothingSlot();
        brazalet = new ClothingSlot();
        glove = new ClothingSlot();
        belt = new ClothingSlot();
        boots = new ClothingSlot();
    }

    public void OnValidate() {
        // if (Player.instance != null)
        ClothingChange?.Invoke();
    }

}