using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHpGage_Ctrl : MonoBehaviour
{

    public GameObject Player;
    public Image PlayerHpGage;

    void Start()
    {
        
    }

    void Update()
    {
        PlayerHpGage.fillAmount = Player.GetComponent<player_Move>().hp;
    }
}
