using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClothingAnimation : MonoBehaviour {

    protected ClothingPiece clothingPiece;
    protected Animator animator;
    protected bool animationEnabled;

    PlayerMovement playerMovement;
    SpriteRenderer spriteRenderer;

    void Awake() {
        playerMovement = GetComponentInParent<PlayerMovement>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnEnable() {
        Clothes.ClothingChange += UpdateAnimation;
    }

    void OnDisable() {
        Clothes.ClothingChange -= UpdateAnimation;
    }

    void Start() {
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

    public abstract void UpdateAnimation();

}
