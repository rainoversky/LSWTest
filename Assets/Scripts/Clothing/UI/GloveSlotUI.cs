using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.glove.clothingPiece == null) {
            image.sprite = null;
        } else {
            image.sprite = Player.instance.clothes.glove.clothingPiece.sprite;
        }
    }

}
