using UnityEngine;

namespace Chapter.State
{
    public class PlayerRightState : MonoBehaviour, IPlayerState
    {
        private PlayerController _pc;

        public void Handle(PlayerController playerController)
        {
            if (!_pc)
                _pc = playerController;

            _pc.CurrentSpeed =
                _pc.maxSpeed;

            playerController.rigB.AddForce(Vector3.right * _pc.SlideVelocity, ForceMode.Impulse);
        }
    }
}
