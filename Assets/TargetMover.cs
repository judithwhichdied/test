using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private int _currentWaypoint = 0;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (_waypoints[_currentWaypoint].position == transform.position && _currentWaypoint < _waypoints.Length - 1)
        {
            _currentWaypoint++;
        }

        if (_currentWaypoint == _waypoints.Length)
        {
            _speed = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);
    }
}
