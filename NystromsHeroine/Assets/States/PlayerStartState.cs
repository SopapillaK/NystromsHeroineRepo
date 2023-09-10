using UnityEngine;

namespace Chapter.State
{
    public class PlayerStartState : MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController; 
        
        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
                _playerController = playerController;
            
            _playerController.CurrentSpeed = 
                _playerController.maxSpeed;
        }
        
        void Update()
        {
            if (_playerController)
            {
                if (_playerController.CurrentSpeed > 0)
                {
                    _playerController.transform.Translate(Vector3.forward * ( _playerController.CurrentSpeed * Time.deltaTime));
                }
            }
        }
    }
}