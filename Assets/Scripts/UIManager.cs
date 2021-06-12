using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public static Action OnNearToVendor;
    public static Action OnStoreYes;
    public static Func<ClothingPiece, bool> OnStoreTryBuy;
    public static Action<ClothingPiece> OnStoreBuy;

    public GameObject dialogueBubble;
    public GameObject clothingPanel;
    public GameObject storeItemsPanel;

    void Awake() {
        dialogueBubble.SetActive(false);
        clothingPanel.SetActive(false);
        storeItemsPanel.SetActive(false);
    }

    void OnEnable() {
        OnNearToVendor += ShowDialogue;
        OnStoreYes += ShowStoreItems;
        OnStoreBuy += UpdateStore;
    }

    void OnDisable() {
        OnNearToVendor -= ShowDialogue;
        OnStoreYes -= ShowStoreItems;
        OnStoreBuy -= UpdateStore;
    }

    void Start() {

    }

    void ShowDialogue() {
        if (!storeItemsPanel.activeInHierarchy) dialogueBubble.SetActive(true);
    }

    void ShowStoreItems() {
        dialogueBubble.SetActive(false);
        clothingPanel.SetActive(true);
        storeItemsPanel.SetActive(true);
    }

    void UpdateStore(ClothingPiece clothingPiece) {
        foreach (StoreItemUI item in GetComponentsInChildren<StoreItemUI>()) {
            if (item.clothingPiece == clothingPiece) Destroy(item.gameObject);
        }
    }

}
