public class AvatarShawl : AvatarClothing {

    protected override void UpdateAvatar() {
        clothingPiece = Player.instance.clothes.shawl;
        if (clothingPiece == null) {
            image.enabled = false;
        } else {
            image.enabled = true;
            image.sprite = clothingPiece.avatarSprite;
        }
    }

}
