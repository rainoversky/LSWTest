using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;

    Rigidbody2D rb2D;
    Vector2 moveV;
    Animator anim;


    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update() {
        moveV.x = Input.GetAxisRaw("Horizontal");
        moveV.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Horizontal", moveV.x);
        anim.SetFloat("Vertical", moveV.y);
        anim.SetFloat("Speed", moveV.sqrMagnitude);
    }

    void FixedUpdate() {
        rb2D.MovePosition(rb2D.position + moveV.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    public Vector2 GetMovementVector() {
        return moveV;
    }

}
