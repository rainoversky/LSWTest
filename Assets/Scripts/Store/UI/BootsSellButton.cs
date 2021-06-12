using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BootsSellButton : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData eventData) {
        Player.instance.SellClothing(Player.instance.clothes.boots);
        Player.instance.clothes.boots = null;
        Player.instance.clothes.OnValidate();
    }
}
