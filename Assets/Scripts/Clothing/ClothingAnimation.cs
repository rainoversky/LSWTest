using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClothingAnimation : MonoBehaviour {

    protected ClothingSlot clothingSlot;

    PlayerMovement playerMovement;
    SpriteRenderer spriteRenderer;
    Animator animator;
    bool animationEnabled;

    void OnEnable() {
        Clothes.ClothingChange += UpdateAnimation;
    }

    void OnDisable() {
        Clothes.ClothingChange -= UpdateAnimation;
    }

    protected void Init() {
        playerMovement = GetComponentInParent<PlayerMovement>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateAnimation();
    }

    void Update() {
        animator.enabled = animationEnabled;
        spriteRenderer.enabled = animationEnabled;
        if (animationEnabled) {
            animator.SetFloat("Horizontal", playerMovement.GetMovementVector().x);
            animator.SetFloat("Vertical", playerMovement.GetMovementVector().y);
            animator.SetFloat("Speed", playerMovement.GetMovementVector().sqrMagnitude);
        }
    }

    void UpdateAnimation() {
        if (clothingSlot == null) return;
        if (clothingSlot.clothingPiece == null) {
            animationEnabled = false;
            animator.runtimeAnimatorController = null;
        } else {
            animationEnabled = true;
            animator.runtimeAnimatorController = clothingSlot.clothingPiece.animatorController;
        }
    }

}
