using UnityEngine;

namespace Chapter.State {
    public class PlayerController : MonoBehaviour {

        public float maxSpeed = 2.0f;
        public float turnDistance = 2.0f;

        public Rigidbody rigB;
        public bool _isGrounded = false;
        private float _jumpVelocity = 7f;
        private float _diveVelocity = 10f;
        private float _slideVelocity = 5f;

        public float JumpVelocity { get { return _jumpVelocity; } }
        public float DiveVelocity { get { return _diveVelocity; } }
        public float SlideVelocity {  get { return _slideVelocity; } }

        public float CurrentSpeed { get; set; }
        
        public Direction CurrentTurnDirection {
            get; private set;
        }

        private IPlayerState
            //_startState
            //_stopState
            //_turnState, 
            _diveState, _duckState, _standState, _leftState, _rightState, _forwardState, _backwardState,
            _jumpState;
        
        private PlayerStateContext _playerStateContext;

        private void Start() {
            _playerStateContext = 
                new PlayerStateContext(this);
            
            /*_startState = 
                gameObject.AddComponent<PlayerStartState>();*/
            /*_stopState = 
                gameObject.AddComponent<PlayerStopState>();*/
            _jumpState = 
                gameObject.AddComponent<PlayerJumpState>();
            _diveState = 
                gameObject.AddComponent<PlayerDiveState>();
            _duckState = 
                gameObject.AddComponent<PlayerDuckState>();
            _standState = 
                gameObject.AddComponent<PlayerStandState>();  
            _leftState = 
                gameObject.AddComponent<PlayerLeftState>();
            _rightState =
                gameObject.AddComponent<PlayerRightState>();
            _forwardState =
                gameObject.AddComponent<PlayerForwardState>();
            _backwardState =
                gameObject.AddComponent<PlayerBackwardState>();

            //_turnState = gameObject.AddComponent<PlayerTurnState>();
            
            //_playerStateContext.Transition(_stopState);
        }

        /*public void StartPlayer() {
            _playerStateContext.Transition(_startState);
        }

        public void StopPlayer() {
            _playerStateContext.Transition(_stopState);
        }*/

        /*public void Turn(Direction direction) {
            CurrentTurnDirection = direction;
            _playerStateContext.Transition(_turnState);
        }*/

        public void Update()
        {
            _isGrounded = Physics.Raycast(transform.position, -Vector3.up, 0.55f);
        }

        public void Jump()
        {
            _playerStateContext.Transition(_jumpState);
        }

        public void Dive()
        {
            _playerStateContext.Transition(_diveState);
        }

        public void Duck()
        {
            _playerStateContext.Transition(_duckState);
        }

        public void Stand()
        {
            _playerStateContext.Transition(_standState);
        }

        public void Left()
        {
            _playerStateContext.Transition(_leftState);
        }

        public void Right()
        {
            _playerStateContext.Transition(_rightState);
        }

        public void Forward()
        {
            _playerStateContext.Transition(_forwardState);
        }

        public void Backward()
        {
            _playerStateContext.Transition(_backwardState);
        }
    }
}