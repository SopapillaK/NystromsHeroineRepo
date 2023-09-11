using UnityEngine;

namespace Chapter.State
{
    public class PlayerStandState : MonoBehaviour, IPlayerState
    {
        private PlayerController _pc;

        public void Handle(PlayerController playerController)
        {
            if (!_pc)
                _pc = playerController;

            _pc.CurrentSpeed =
                _pc.maxSpeed;


            playerController.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
