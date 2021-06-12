using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootsSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.boots.clothingPiece == null) {
            image.sprite = null;
        } else {
            image.sprite = Player.instance.clothes.boots.clothingPiece.sprite;
        }
    }

}
