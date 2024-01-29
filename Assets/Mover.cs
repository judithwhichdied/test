using System;
using UnityEngine;

[RequireComponent(typeof(Animator))] 

public class Mover : MonoBehaviour
{
    [NonSerialized] public Transform Target;
    [NonSerialized] public float Speed;
    
    private Animator _animator;

    private const string _animationParameter = "Speed";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();

        _animator.SetFloat(_animationParameter, Speed);
    }

    private void Move()
    {
        transform.LookAt(Target.position);

        transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
    }
}