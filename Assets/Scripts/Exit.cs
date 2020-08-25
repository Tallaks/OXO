using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    Button _thisButton;

    // Start is called before the first frame update
    void Start()
    {
        _thisButton = GetComponent<Button>();
        _thisButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}
