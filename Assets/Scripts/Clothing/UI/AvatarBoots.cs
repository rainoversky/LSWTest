public class AvatarBoots : AvatarClothing {

    protected override void UpdateAvatar() {
        clothingPiece = Player.instance.clothes.boots;
        if (clothingPiece == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = clothingPiece.avatarSprite;
        }
    }

}
