using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrazaletSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.brazalet == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = Player.instance.clothes.brazalet.itemSprite;
        }
    }

}
