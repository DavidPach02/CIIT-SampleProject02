using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestPlayer : MonoBehaviour
{
    //I changed a line of code yay
    //Variables to be used can go here above the functions.
    private int _counter = 0;
    private float _horizontal;
    private float _speed;
    private float _jumpPower;
    private bool _isFacingRight = true;

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Transform _groundChecker;
    [SerializeField] private LayerMask _groundLayer;

    public Transform GroundChecker { get => _groundChecker; set => _groundChecker = value; }
    public float JumpPower { get => _jumpPower; set => _jumpPower = value; }


    // Awake is called ahead of Start and OnEnable.
    void Awake ()
    {
        Debug.Log("Awake is running!");
        
    }

    //OnEnable is called ahead of Start and after Awake. 
    //Good for resetting objects when needed.
    void OnEnable () 
    {
        Debug.Log("OnEnable is running!");
        _speed = 5f;
        _jumpPower = 5f;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start is running!");
        TestGameManager.instance.GetBaseJumpValue(JumpPower);
    }

    // Update is called once per frame
    void Update()
    {
        if (_counter <= 0)
        {
            Debug.Log("Update is running!");
            _counter++;
        }

        //MOVEMENT
        _horizontal = Input.GetAxisRaw("Horizontal");
        Flip();
        _rigidbody.velocity = new Vector2(_horizontal *_speed, _rigidbody.velocity.y);  
        //JUMP
        Jump();
    }

    void OnDisable()
    {
        Debug.Log("OnDisable is running!");
    }

    void OnDestroy ()
    {
        Debug.Log("OnDestroy is running!");
        Application.LoadLevel (Application.loadedLevel);
    }

    //MOVEMENT FUNCTIONS
    private void Flip()
    {
        if (_isFacingRight && _horizontal < 0f || !_isFacingRight && _horizontal > 0f) 
        {
            _isFacingRight = !_isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, JumpPower);
        }
        if (Input.GetButtonUp("Jump") && _rigidbody.velocity.y > 0f)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.y * 0.2f);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle (_groundChecker.position, 0.2f, _groundLayer);
    }
}
