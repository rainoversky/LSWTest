public class AvatarBrazalet : AvatarClothing {

    protected override void UpdateAvatar() {
        clothingPiece = Player.instance.clothes.brazalet;
        if (clothingPiece == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = clothingPiece.avatarSprite;
        }
    }
}
