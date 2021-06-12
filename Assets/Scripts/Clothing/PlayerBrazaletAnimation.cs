using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBrazaletAnimation : ClothingAnimation {

    void Start() {
        clothingSlot = Player.instance.clothes.brazalet;
        Init();
    }

}
