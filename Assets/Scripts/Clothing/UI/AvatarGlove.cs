public class AvatarGlove : AvatarClothing {

    protected override void UpdateAvatar() {
        clothingPiece = Player.instance.clothes.glove;
        if (clothingPiece == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = clothingPiece.avatarSprite;
        }
    }

}
