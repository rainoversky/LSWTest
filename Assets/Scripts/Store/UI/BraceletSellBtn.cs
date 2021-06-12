using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BraceletSellBtn : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData eventData) {
        Player.instance.SellClothing(Player.instance.clothes.bracelet);
        Player.instance.clothes.bracelet = null;
        Player.instance.clothes.OnValidate();
    }
}
