using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterScene : MonoBehaviour
{
    public static string playerName;
    public TextMeshProUGUI text;
    Button bt;
    // Start is called before the first frame update
    void Start()
    {
        bt = GetComponent<Button>();
        bt.onClick.AddListener(Enter1);
    }

    public void Enter1() 
    {
        playerName = text.text;
        SceneManager.LoadScene(1);
    }
}
