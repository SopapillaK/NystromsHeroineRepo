using UnityEngine;

namespace Chapter.State
{
    public class PlayerTurnState : MonoBehaviour, IPlayerState
    {
        private Vector3 _turnDirection;
        private PlayerController _playerController;
        
        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
                _playerController = playerController;
            
            _turnDirection.x = 
                (float) _playerController.CurrentTurnDirection;

            if (_playerController.CurrentSpeed > 0)
            {
                transform.Translate(_turnDirection * _playerController.turnDistance);
            }
        }
    }
}