using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private GameController _controller;
    [SerializeField] private int _horizontalLineNumber;
    [SerializeField] private int _verticalLineNumber;

    private SpriteRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (!_renderer.sprite && !_controller.GameIsFinished)
        {
            _renderer.sprite = _controller.CurrentPlayer == 1 ? _controller.X : _controller.O;
            _controller.SetCellValue(_horizontalLineNumber, _verticalLineNumber);
            _controller.NextPlayer();
        }
    }
}
