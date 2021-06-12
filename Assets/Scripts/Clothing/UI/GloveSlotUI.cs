using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.glove == null) {
            image.sprite = null;
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = Player.instance.clothes.glove.itemSprite;
        }
    }

}
