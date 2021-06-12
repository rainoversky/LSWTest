using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShawlSellBtn : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData eventData) {
        Player.instance.SellClothing(Player.instance.clothes.shawl);
        Player.instance.clothes.shawl = null;
        Player.instance.clothes.OnValidate();
    }

}
