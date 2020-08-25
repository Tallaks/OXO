using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text _currentPlayerLabel;

    private int[,] _checkingTable;

    public bool GameIsFinished;

    public Sprite X; // Спрайт крестика
    public Sprite O; // Спрайт  нолика

    public int CurrentPlayer; // Номер текущего игрока

    // Start is called before the first frame update
    private void Start()
    {
        CurrentPlayer = 1;
        _checkingTable = new int[3, 3] { {0,0,0},{0,0,0},{0,0,0} };
        GameIsFinished = false;
    }

    public void NextPlayer()
    {
        if (!CheckWin())
        {
            CurrentPlayer = CurrentPlayer == 1 ? 2 : 1;
            _currentPlayerLabel.text = CurrentPlayer == 1 ? "Ходит первый игрок" : "Ходит второй игрок";
        }
        else
        {
            GameIsFinished = true;
            _currentPlayerLabel.text = CurrentPlayer == 1 ? "Первый игрок выиграл!" : "Второй игрок выиграл!";
        }
    }

    public void SetCellValue(int horizontalIndex, int verticalIndex)
    {
        _checkingTable[horizontalIndex-1, verticalIndex-1] = CurrentPlayer;
    }

    private bool CheckWin()
    {
        bool currentPlayerWon = false;

        if (_checkingTable[0, 0] == _checkingTable[1, 1] && _checkingTable[0, 0] == _checkingTable[2, 2] && _checkingTable[0, 0] == CurrentPlayer)
        {
            currentPlayerWon = true;
        }

        if (_checkingTable[2, 0] == _checkingTable[1, 1] && _checkingTable[2, 0] == _checkingTable[0, 2] && _checkingTable[2, 0] == CurrentPlayer)
        {
            currentPlayerWon = true;
        }

        for (int i = 0; i < 3; i++)
        {
            if (_checkingTable[i, 0] == _checkingTable[i, 1] && _checkingTable[i, 0] == _checkingTable[i, 2] && _checkingTable[i, 0] == CurrentPlayer)
            {
                currentPlayerWon = true;
                break;
            }

            if (_checkingTable[0, i] == _checkingTable[1, i] && _checkingTable[0, i] == _checkingTable[2, i] && _checkingTable[0, i] == CurrentPlayer)
            {
                currentPlayerWon = true;
                break;
            }
        }

        return currentPlayerWon;
    }
}
