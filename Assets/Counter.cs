using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int _currentCounterValue = 0;

    private bool _isActive = false;

    private float _delay = 0.5f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isActive == false)
        {
            _isActive = true;

            StartCoroutine(ValueChanging(_delay));
        }
        else if (Input.GetMouseButtonDown(0) && _isActive == true)
        {
            _isActive = false;

            StopAllCoroutines();       
        }       
    }

    private IEnumerator ValueChanging(float delay)
    {
        WaitForSeconds wait = new WaitForSeconds(delay);

        while (true)
        {
            Debug.Log(_currentCounterValue);

            _currentCounterValue++;

            yield return wait;
        }
    }
}
