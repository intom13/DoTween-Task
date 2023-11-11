using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _movingEndValue;
    [SerializeField] private float _movingDuration;

    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _transform.DOMoveZ(_movingEndValue, _movingDuration);
    }
}
