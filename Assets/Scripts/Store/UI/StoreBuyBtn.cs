using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StoreBuyBtn : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData eventData) {
        if (UIManager.OnStoreTryBuy.Invoke(GetComponentInParent<StoreItemUI>().clothingPiece)) {
            UIManager.OnStoreBuy?.Invoke(GetComponentInParent<StoreItemUI>().clothingPiece);
        } else {
            Debug.Log("Cannot buy the item");
        }
    }

}
