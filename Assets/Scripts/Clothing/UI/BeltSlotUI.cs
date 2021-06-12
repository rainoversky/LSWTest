using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.belt.clothingPiece == null) {
            image.sprite = null;
        } else {
            image.sprite = Player.instance.clothes.belt.clothingPiece.itemSprite;
        }
    }

}
