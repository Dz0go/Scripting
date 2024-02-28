using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    static UI singleton;
    public GameObject panel;
    public Text panelScoreText;
    public Text defeatText;
    public Text victoriText;
    public Text scoreText;
    private void Awake()
    {
        singleton = this;
    }
    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = Player.score.ToString();
    }
    public static void ShowVictoryPanel()
    {
        singleton.panel.SetActive(true);
        singleton.victoriText.gameObject.SetActive(true);
        singleton.panelScoreText.text = Player.score.ToString();
    }
    public static void ShowDefeatPanel()
    {
        singleton.panel.SetActive(true);
        singleton.victoriText.gameObject.SetActive(true);
        singleton.panelScoreText.text = Player.score.ToString();
    }
    public void OneClickRestart()
    {
        Player.Restart(); 
    }
}
