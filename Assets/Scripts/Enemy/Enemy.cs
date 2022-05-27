using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] CharacterController _enemy;
    [SerializeField] private int _health;
    [SerializeField] private Transform _graundCheck;
    [SerializeField] private LayerMask _groundMask;
    [SerializeField] private float _groundDistance = 0.4f;
    [SerializeField] private float _gravity = 9.8f;
    [SerializeField] private float _massEnemy;
    [SerializeField] private Player _target;


    private bool _isGrounded;

    Mover mover = new Mover();
    public Player Target => _target;

    private void Update()
    {
        _isGrounded = mover.GroundedChek(_graundCheck, _groundMask, _groundDistance);

        mover.Gravity(_enemy, _isGrounded, _massEnemy, _gravity);
    }




}
