public class AvatarBelt : AvatarClothing {

    protected override void UpdateAvatar() {
        clothingPiece = Player.instance.clothes.belt;
        if (clothingPiece == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = clothingPiece.avatarSprite;
        }
    }

}
