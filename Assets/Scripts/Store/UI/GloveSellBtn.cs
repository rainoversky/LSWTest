using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GloveSellBtn : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData eventData) {
        Player.instance.SellClothing(Player.instance.clothes.glove);
        Player.instance.clothes.glove = null;
        Player.instance.clothes.OnValidate();
    }
}
