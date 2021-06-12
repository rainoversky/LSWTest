using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShawlSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.shawl.clothingPiece == null) {
            image.sprite = null;
        } else {
            image.sprite = Player.instance.clothes.shawl.clothingPiece.sprite;
        }
    }

}
