using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootsSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.boots == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = Player.instance.clothes.boots.itemSprite;
        }
    }

}
