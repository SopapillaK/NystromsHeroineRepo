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
            if (Input.GetKey("w"))
            {
                Debug.Log("Go");
                _playerController.StartPlayer();
            }
            
            if (Input.GetKey("a"))
            {
                Debug.Log("left");
                _playerController.Turn(Direction.Left);
            }
            
            if (Input.GetKey("d"))
            {
                Debug.Log("right");
                _playerController.Turn(Direction.Right);
            }
            
            if (Input.GetKey("s"))
            {
                Debug.Log("stop");
                _playerController.StopPlayer();
            }
        }
    }
}