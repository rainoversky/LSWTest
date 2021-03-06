using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClothingPiece : ScriptableObject {

    public string clothingPieceName;
    public float price;
    public Sprite itemSprite;
    public Sprite avatarSprite;
    public RuntimeAnimatorController animatorController;

}
