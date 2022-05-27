using UnityEngine;

public class DistanseTransitionToAttack : Transition
{
    [SerializeField] private float _transitionRange;
    [SerializeField] private float _rengeSpread;

    private void Start()
    {
        _transitionRange += Random.Range(-_rengeSpread, _rengeSpread);
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position, Target.transform.position) < _transitionRange)
        {
            NeedTransit = true;
        }
    }
}
