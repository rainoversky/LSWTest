using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/Clothes")]
public class Clothes : ScriptableObject {

    public static Action ClothingChange;
    public Shawl shawl;
    public Brazalet brazalet;
    public Glove glove;
    public Belt belt;
    public Boots boots;

    public void OnValidate() {
        ClothingChange?.Invoke();
    }

}