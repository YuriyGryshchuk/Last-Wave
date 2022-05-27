using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject _weapon;
    [SerializeField] private float _weaponSpeed = 10f;
    [SerializeField] private Animator _fireAnimation;
    [SerializeField] private AudioSource _weaponSource;
    

    // Start is called before the first frame update
    void Start()
    {
        _fireAnimation = GetComponent<Animator>();
        _weaponSource = GetComponent<AudioSource>();

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _fireAnimation.SetTrigger("Shoot");
            _weaponSource.Play();
        }
            

                
    }
}


