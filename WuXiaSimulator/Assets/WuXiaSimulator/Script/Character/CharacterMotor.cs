using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour
{
    public WalkSetting walkSetting = WalkSetting.Default();

    private Animator _animator;
    private Rigidbody2D _body;

    private float _input_X, _input_Y;
    private bool _isWalking = false;

    public bool IsWalking { set { _isWalking = value; } get { return _isWalking; } }

    public void InputMovement(float x, float y)
    {
        _isWalking = true;
        _input_X = x;
        _input_Y = y;       
    }


    void Start()
    {
        if (!_animator)
            _animator = GetComponent<Animator>();
        if (!_body)
            _body = GetComponent<Rigidbody2D>();
    }

    #region FixUpdate Method
    private void FixedUpdate()
    {
        var dt = Time.fixedDeltaTime;

        _moveUpdate(dt);
    }

    private void _moveUpdate(float dt)
    {
        Vector2 moveTemp = new Vector2(_input_X, _input_Y);

        if(_isWalking)
            _body.MovePosition(_body.position + moveTemp * dt * walkSetting.Speed);
    }

    #endregion

    #region Private Method
    /// <summary>
    /// 检测移动是否可行
    /// </summary>
    private void _moveDetective()
    {

    }

    #endregion

    #region Update Method
    private void Update()
    {
        _updateAnimtion();
    }

    private void _updateAnimtion()
    {
        _animator.SetBool("IsWalking", _isWalking);
        _animator.SetFloat("Input_x", _input_X);
        _animator.SetFloat("Input_y", _input_Y);
    }

    #endregion
}
