using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomHead : MonoBehaviour
{
    Button bt;
    public Image go;
    public Sprite sp1;
    public Sprite sp2;
    public Sprite sp3;
    // Start is called before the first frame update
    void Start()
    {
        bt=GetComponent<Button>();
        bt.onClick.AddListener(Random1);
    }

    public void Random1() 
    { 
       int a=Random.Range(0,3);
        switch (a)
        {
            case 0:  go.sprite = sp1; break;
            case 1: go.sprite = sp2; break;
            case 2: go.sprite = sp3; break;
        }
    }
}
