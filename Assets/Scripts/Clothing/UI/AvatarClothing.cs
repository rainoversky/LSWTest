using UnityEngine;
using UnityEngine.UI;

public abstract class AvatarClothing : MonoBehaviour {

    protected ClothingPiece clothingPiece;
    protected Image image;

    void OnEnable() {
        Clothes.ClothingChange += UpdateAvatar;
    }

    void OnDisable() {
        Clothes.ClothingChange -= UpdateAvatar;
    }

    void Start() {
        image = GetComponent<Image>();
        UpdateAvatar();
    }

    protected abstract void UpdateAvatar();



}
