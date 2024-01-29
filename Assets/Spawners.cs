using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners = new List<Spawner>();

    private void Start()
    {        
        StartCoroutine(Respawn());
    }

    private IEnumerator Respawn()
    {
        int delay = 2;

        var wait = new WaitForSecondsRealtime(delay);

        for(int i = 0; i < _spawners.Count; i++)
        {
            _spawners[i].Spawn();

            yield return wait;
        }
    }
}