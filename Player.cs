using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int score = 0;
    public static List<Square> squares;
    

    
    void Start()
    {
        
    }

    void Update()
    {
        if (squares.Count == 0)
        {
            Victory();
        }
    }
    public static void Defeat()
    {
        score = 0;
    }
    void Awake()
    {
        squares = new List<Square>();
    }
        public static void Victory()
        {
            UI.ShowVictoryPanel();
        }
    public static void Restart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
