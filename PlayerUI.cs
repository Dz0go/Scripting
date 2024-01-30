using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    public Slider healthBar;
    public TMPro.TextMeshProUGUI CoinsCounter;
    public Player player;
    void Start()
    {
        healthBar.maxValue = player.maxHealth;
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coins;
    }
    void Update()
    {
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coins;
    }
}

