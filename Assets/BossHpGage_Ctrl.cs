using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHpGage_Ctrl : MonoBehaviour
{
    public GameObject Boss;
    public Image BossHpGage;

    void Start()
    {
        
    }

    void Update()
    {
        if (Boss != null)
        {
            BossHpGage.fillAmount = Boss.GetComponent<Boss_Move>().hp2 * 0.01f;
            if (BossHpGage.fillAmount < 0.1f)
            {
                BossHpGage.fillAmount = 0.01f;
            }
        }
    }
}
