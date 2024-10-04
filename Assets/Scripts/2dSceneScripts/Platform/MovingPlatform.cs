using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] bool _isMovingRight = false;

    [SerializeField] Transform _startRef;
    [SerializeField] Transform _endRef;
    [SerializeField] Rigidbody2D _platform;

    [SerializeField] Transform _targetTransform;
    float _direction = -1f;

    // Start is called before the first frame update
    void Start()
    {
        _targetTransform = _startRef;
        _isMovingRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posDiff = _platform.transform.position - _targetTransform.position;
        if (Vector3.Distance(_platform.transform.position, _targetTransform.position) <= 1f)
        {
            if (!_isMovingRight)
            {
                _isMovingRight = true;
                _targetTransform = _startRef;
                _direction = 1f;
            }
            else
            {
                _isMovingRight = false;
                _targetTransform = _endRef;
                _direction = -1f;
            }
        }

        //_platform.transform.position = Vector2.MoveTowards(_platform.transform.position, _targetTransform.position, _speed * Time.deltaTime);
        _platform.velocity = (Vector2.right * _direction) * _speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        other.transform.SetParent(_platform.transform);
    }

    void OnCollisionExit2D(Collision2D other)
    {
        other.transform.SetParent(null);
    }
}
