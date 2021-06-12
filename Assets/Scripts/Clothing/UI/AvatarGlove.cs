public class AvatarGlove : AvatarClothing {

    void Start() {
        clothingSlot = Player.instance.clothes.glove;
        Init();
    }

}
