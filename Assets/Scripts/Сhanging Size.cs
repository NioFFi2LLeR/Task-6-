using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СhangingSize : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
