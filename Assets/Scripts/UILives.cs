using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILives : MonoBehaviour
{
    public static int lives;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        lives = 3;
    }

    void Update()
    {
        text.text = "Lives: " + lives;
    }
}
