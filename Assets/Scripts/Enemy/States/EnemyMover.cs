using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : State
{
    [SerializeField] private float _speed = 5f;

    private CharacterController _EnemyController;
    private Animator _moveAnimation;
    private Vector3 _vectorToTarget;

    Mover mover = new Mover();

    private void Start()
    {
        _EnemyController = GetComponent<CharacterController>();
        _moveAnimation = GetComponent<Animator>();
    }

    void Update()
    {
        _moveAnimation.SetTrigger("ToMove");

        _vectorToTarget = mover.GetVectorToTarget(_EnemyController, Target, _speed);

        mover.RotateToVector(_EnemyController, _vectorToTarget);
        mover.MoveToVector(_EnemyController, _vectorToTarget, _speed);
    }
    
}
