public class AvatarBelt : AvatarClothing {

    void Start() {
        clothingSlot = Player.instance.clothes.belt;
        Init();
    }

}
