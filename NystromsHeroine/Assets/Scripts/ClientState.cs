using UnityEngine;

namespace Chapter.State
{
    public class ClientState : MonoBehaviour
    {
        private PlayerController _playerController;

        void Start()
        {
            _playerController =
                (PlayerController)
                FindObjectOfType(typeof(PlayerController));
        }
        
        void Update() 
        {
            /*if (Input.GetKey("w"))
            {
                Debug.Log("Go");
                _playerController.StartPlayer();
            }*/
            if (Input.GetKeyDown(KeyCode.LeftShift) && _playerController._isGrounded)
            {
                Debug.Log("Duck");
                _playerController.Duck();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Debug.Log("stand");
                _playerController.Stand();
            }

            if (Input.GetKeyDown(KeyCode.Space) && _playerController._isGrounded)
            {
                Debug.Log("Jump");
                _playerController.Jump();
            }

            if (Input.GetKeyDown(KeyCode.LeftShift) && !_playerController._isGrounded)
            {
                Debug.Log("Dive");
                _playerController.Dive();
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("forward");
                _playerController.Forward();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("left");
                _playerController.Left();
            }
            
            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("right");
                _playerController.Right();
            }
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("stop");
                _playerController.Backward();
            }
        }
    }
}