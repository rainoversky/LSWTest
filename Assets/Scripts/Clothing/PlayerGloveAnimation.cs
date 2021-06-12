using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGloveAnimation : ClothingAnimation {

    void Start() {
        clothingSlot = Player.instance.clothes.glove;
        Init();
    }

}
