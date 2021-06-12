﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrazaletSlotUI : ClothingSlotUI {

    public override void UpdateSlot() {
        if (Player.instance.clothes.brazalet.clothingPiece == null) {
            image.sprite = null;
        } else {
            image.sprite = Player.instance.clothes.brazalet.clothingPiece.sprite;
        }
    }

}
