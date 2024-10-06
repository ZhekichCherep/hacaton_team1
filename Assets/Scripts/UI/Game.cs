using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Game : MonoBehaviour
{
    public static Game Instance;
    private UIManager uiManager;

    private void Start()
    {
        Instance = this;
        uiManager = FindObjectOfType<UIManager>(); 
    }

    public void ShowMessage(string message)
    {
        if (uiManager != null)
        {
            uiManager.ShowMessage(message);
        }
    }
}
