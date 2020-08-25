using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
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
        CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
    }
}
