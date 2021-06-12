using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.belt == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = Player.instance.clothes.belt.itemSprite;
        }
    }

}
