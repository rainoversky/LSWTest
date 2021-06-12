using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemUI : MonoBehaviour {

    public ClothingPiece clothingPiece;
    public Image itemImage;
    public Text itemName;
    public Text itemPrice;

    void Start() {
        itemImage.sprite = clothingPiece.itemSprite;
        itemName.text = clothingPiece.clothingPieceName;
        itemPrice.text = clothingPiece.price.ToString() + " $";
    }

}
