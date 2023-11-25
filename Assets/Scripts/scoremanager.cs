using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoremanager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI monUI;
    public int elimination = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monUI.text = score.ToString();

    }
}
