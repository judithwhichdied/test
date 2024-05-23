using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int _currentValue = 0;

    private bool _isActive = false;

    private float _delay = 0.5f;

    private Coroutine _coroutine;

    private int _mouseButton = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_mouseButton))
        {
            if (_isActive == false)
            {
                _isActive = true;

                _coroutine = StartCoroutine(ChangeValue(_delay));
            }
            else
            {
                _isActive = false;

                StopCoroutine(_coroutine);
            }
        }  
    }

    private IEnumerator ChangeValue(float delay)
    {
        WaitForSeconds wait = new WaitForSeconds(delay);

        bool isWorking = true;

        while (isWorking)
        {
            Debug.Log(_currentValue);

            _currentValue++;

            yield return wait;
        }
    }
}
