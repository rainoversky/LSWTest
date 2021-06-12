using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Clothes clothes;
    public static Player instance;
    public static Action OnCreditsChange;
    public float credits { private set; get; }

    void Awake() {
        instance = this;
        clothes.OnValidate();
    }

    void OnEnable() {
        UIManager.OnStoreTryBuy += TryToEquipClothing;
    }

    void OnDisable() {
        UIManager.OnStoreTryBuy -= TryToEquipClothing;
    }

    private void Start() {
        credits = 290;
    }

    bool TryToEquipClothing(ClothingPiece clothingPiece) {
        bool equiped = true;
        if (!IsThereEnoughCredits(clothingPiece)) return false;
        switch (clothingPiece) {
            case Shawl shawl:
                if (clothes.shawl == null) clothes.shawl = clothingPiece as Shawl;
                else equiped = false;
                break;
            case Brazalet brazalet:
                if (clothes.brazalet == null) clothes.brazalet = clothingPiece as Brazalet;
                else equiped = false;
                break;
            case Glove glove:
                if (clothes.glove == null) clothes.glove = clothingPiece as Glove;
                else equiped = false;
                break;
            case Belt belt:
                if (clothes.belt == null) clothes.belt = clothingPiece as Belt;
                else equiped = false;
                break;
            case Boots boots:
                if (clothes.boots == null) clothes.boots = clothingPiece as Boots;
                else equiped = false;
                break;
            default:
                equiped = false;
                break;
        }
        if (equiped) {
            credits -= clothingPiece.price;
            OnCreditsChange?.Invoke();
            clothes.OnValidate();
        }
        return equiped;
    }

    bool IsThereEnoughCredits(ClothingPiece clothingPiece) {
        return credits - clothingPiece.price >= 0;
    }

    public void SellClothing(ClothingPiece clothingPiece) {
        credits += clothingPiece.price * 0.5f;
        OnCreditsChange?.Invoke();
    }

}
