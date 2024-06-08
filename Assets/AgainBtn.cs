using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AgainBtn : MonoBehaviour
{
    public void AgainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
