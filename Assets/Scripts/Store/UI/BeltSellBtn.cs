using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BeltSellBtn : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData eventData) {
        Player.instance.SellClothing(Player.instance.clothes.belt);
        Player.instance.clothes.belt = null;
        Player.instance.clothes.OnValidate();
    }
}
