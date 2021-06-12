public class AvatarShawl : AvatarClothing {

    void Start() {
        clothingSlot = Player.instance.clothes.shawl;
        Init();
    }

}
