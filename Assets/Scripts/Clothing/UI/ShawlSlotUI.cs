using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShawlSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.shawl == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = Player.instance.clothes.shawl.itemSprite;
        }
    }

}
