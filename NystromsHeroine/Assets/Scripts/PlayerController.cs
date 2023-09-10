using UnityEngine;

namespace Chapter.State {
    public class PlayerController : MonoBehaviour {
        
        public float maxSpeed = 2.0f;
        public float turnDistance = 2.0f;
        
        public float CurrentSpeed { get; set; }
        
        public Direction CurrentTurnDirection {
            get; private set;
        }
        
        private IPlayerState 
            _startState, _stopState, _turnState;
        
        private PlayerStateContext _playerStateContext;

        private void Start() {
            _playerStateContext = 
                new PlayerStateContext(this);
            
            _startState = 
                gameObject.AddComponent<PlayerStartState>();
            _stopState = 
                gameObject.AddComponent<PlayerStopState>();
            _turnState = 
                gameObject.AddComponent<PlayerTurnState>();
            
            _playerStateContext.Transition(_stopState);
        }

        public void StartPlayer() {
            _playerStateContext.Transition(_startState);
        }

        public void StopPlayer() {
            _playerStateContext.Transition(_stopState);
        }
        
        public void Turn(Direction direction) {
            CurrentTurnDirection = direction;
            _playerStateContext.Transition(_turnState);
        }
    }
}