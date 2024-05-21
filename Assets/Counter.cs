using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int _value = 0;

    private bool _isActive = false;

    private float _delay = 0.5f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isActive == false)
        {
            _isActive = true;

            StartCoroutine(_valueChanging(_delay));
        }
        else if (Input.GetMouseButtonDown(0) && _isActive == true)
        {
            _isActive = false;

            StopAllCoroutines();
        }       
    }

    private IEnumerator _valueChanging(float delay)
    {
        WaitForSeconds wait = new WaitForSeconds(delay);

        while (true)
        {
            Debug.Log(_value);

            _value++;

            yield return wait;
        }
    }
}
