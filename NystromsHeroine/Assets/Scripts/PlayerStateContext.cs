namespace Chapter.State
{
    public class PlayerStateContext
    {
        public IPlayerState CurrentState
        {
            get; set;
        }
        
        private readonly PlayerController _playerController;

        public PlayerStateContext(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void Transition()
        {
            CurrentState.Handle(_playerController);
        }
        
        public void Transition(IPlayerState state)
        {
            CurrentState = state;
            CurrentState.Handle(_playerController);
        }
    }
}