using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtacker : State
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _damage = 20;

    private Animator _attackAnimation;
    private CharacterController _EnemyController;
    private Vector3 _vectorToTarget;
    private float _timeWithAttack = 2;
    private float _time = 0;


    Mover mover = new Mover();

    private void Start()
    {
        _attackAnimation = GetComponent<Animator>();
        _EnemyController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        _attackAnimation.SetTrigger("ToAttack");

        if (_time >= _timeWithAttack)
        {
            Target.ApplyDamage(_damage);
            _time = 0;
        }
        _time += Time.deltaTime;

        _vectorToTarget = mover.GetVectorToTarget(_EnemyController, Target, _speed);

        mover.RotateToVector(_EnemyController, _vectorToTarget);
    }
}