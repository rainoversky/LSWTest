using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeltAnimation : ClothingAnimation {

    void Start() {
        clothingSlot = Player.instance.clothes.belt;
        Init();
    }

}
