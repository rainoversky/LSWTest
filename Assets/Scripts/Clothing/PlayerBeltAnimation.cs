using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeltAnimation : ClothingAnimation {

    public override void UpdateAnimation() {
        clothingPiece = Player.instance.clothes.belt;
        if (clothingPiece == null) {
            animationEnabled = false;
            animator.runtimeAnimatorController = null;
        } else {
            animationEnabled = true;
            animator.runtimeAnimatorController = clothingPiece.animatorController;
        }
    }

}
