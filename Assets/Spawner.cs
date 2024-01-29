using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Mover _prefab;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Transform _target;
    [SerializeField] private float _enemySpeed;
   
    private Mover _enemy;

    private void Start()
    {
        Create();

        SetTarget();

        _enemy.Speed = _enemySpeed;
    }

    public void Spawn()
    {
        Start();
    }

    private void Create()
    {
        _enemy = Instantiate(_prefab, _spawnPosition);
    }

    private void SetTarget()
    {
        _enemy.Target = _target;
    }
}