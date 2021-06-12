using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBootsAnimation : ClothingAnimation {

    void Start() {
        clothingSlot = Player.instance.clothes.boots;
        Init();
    }

}
