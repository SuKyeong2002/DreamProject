using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene("Main");
    }
}
