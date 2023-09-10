using UnityEngine;

namespace Chapter.State
{
    public class PlayerStopState : MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController; 
        
        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
                _playerController = playerController;

            _playerController.CurrentSpeed = 0;
        }
    }
}