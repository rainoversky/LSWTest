public class AvatarBracelet : AvatarClothing {

    protected override void UpdateAvatar() {
        clothingPiece = Player.instance.clothes.bracelet;
        if (clothingPiece == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = clothingPiece.avatarSprite;
        }
    }
}
