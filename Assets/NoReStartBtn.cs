using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoReStartBtn : MonoBehaviour
{
    public void NoReStartScene()
    {
        SceneManager.LoadScene("Main");
    }
}
