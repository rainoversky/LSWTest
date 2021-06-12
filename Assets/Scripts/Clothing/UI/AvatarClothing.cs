using UnityEngine;
using UnityEngine.UI;

public abstract class AvatarClothing : MonoBehaviour {
    
    protected ClothingSlot clothingSlot;
    Image image;

    void OnEnable() {
        Clothes.ClothingChange += UpdateAvatar;
    }

    void OnDisable() {
        Clothes.ClothingChange -= UpdateAvatar;
    }

    protected void Init() {
        image = GetComponent<Image>();
        UpdateAvatar();
    }

    void UpdateAvatar() {
        if (clothingSlot.clothingPiece == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = clothingSlot.clothingPiece.avatarSprite;
        }
    }

}
