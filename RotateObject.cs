using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotatingDuration;

    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();

        _transform.DORotate(new Vector3(179, 0, 0), _rotatingDuration).SetLoops(-1, LoopType.Restart);
    }
}
