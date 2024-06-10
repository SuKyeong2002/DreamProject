using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollarGut_Dialog : MonoBehaviour
{
    public GameObject aPoint;
    public GameObject bPoint;
    public GameObject dialog;
    float ab_Distance;
    float alpha = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        ab_Distance = Vector3.Distance(aPoint.transform.position, bPoint.transform.position);
        if (ab_Distance < 3.0f)
        {
            dialog.SetActive(true);
            if (alpha > 0)
            {
                dialog.GetComponent<Image>().color = new Color(1, 1, 1, alpha);
                alpha -= Time.deltaTime * 0.1f;
            }
            else
            {
                dialog.SetActive(false);
            }
        }
        else
        {
            dialog.SetActive(false);
        }
    }
}
