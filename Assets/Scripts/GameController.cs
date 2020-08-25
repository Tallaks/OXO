using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text _currentPlayerLabel;

    public Sprite X; // Спрайт крестика
    public Sprite O; // Спрайт  нолика

    public int CurrentPlayer; // Номер текущего игрока

    // Start is called before the first frame update
    private void Start()
    {
        CurrentPlayer = 1;
    }

    public void NextPlayer()
    {
        CurrentPlayer = CurrentPlayer == 1 ? 2 : 1;
        _currentPlayerLabel.text = CurrentPlayer == 1 ? "Ходит первый игрок" : "Ходит второй игрок";
    }
}
