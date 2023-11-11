using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    [SerializeField] private Color _firstColor;
    [SerializeField] private Color _secondColor;

    [SerializeField] private float _textChangingDuration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("яёниор", _textChangingDuration));
        sequence.Insert(0, _text.DOColor(_firstColor, _textChangingDuration));

        sequence.Append(_text.DOText(".translate(Eng)", _textChangingDuration).SetRelative());

        sequence.Append(_text.DOText("I'm a junior", _textChangingDuration, true, ScrambleMode.All));
        sequence.Insert(2, _text.DOColor(_secondColor, _textChangingDuration));

        sequence.SetLoops(-1, LoopType.Restart);
    }
}
