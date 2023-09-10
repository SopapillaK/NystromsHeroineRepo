namespace Chapter.State
{
    public interface IPlayerState
    {
        void Handle(PlayerController controller);
    }
}