using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShawlAnimation : ClothingAnimation {

    void Start() {
        clothingSlot = Player.instance.clothes.shawl;
        Init();
    }

}
