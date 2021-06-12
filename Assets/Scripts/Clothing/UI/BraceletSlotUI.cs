using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BraceletSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.bracelet == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = Player.instance.clothes.bracelet.itemSprite;
        }
    }

}
