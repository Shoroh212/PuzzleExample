using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAnswers : MonoBehaviour
{

    public int score;
    public int totalCount =1;

    [SerializeField] GameObject _panel;

    public void OnEnable()
    {
        ItemSlot.ItemPlaced += ChekAnswers;
    }

    public void OnDisable()
    {
        ItemSlot.ItemPlaced -= ChekAnswers;
    }

    public void ChekAnswers( )
    {
        score++;


        if ( score == totalCount )
        {
            WinPanel();
        }
    }

    void WinPanel()
    {
        Debug.LogWarning("Win");
        _panel.SetActive(true);
    }
}


