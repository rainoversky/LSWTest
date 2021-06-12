public class AvatarBoots : AvatarClothing {

    void Start() {
        clothingSlot = Player.instance.clothes.boots;
        Init();
    }

}
