using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _growingDuration;
    [SerializeField] private float _growingEndValue;

    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _transform.DOScale(_growingEndValue, _growingDuration);
    }
}
