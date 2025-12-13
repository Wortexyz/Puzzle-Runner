using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] GameObject WinPannel;
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level1");
        WinPannel.SetActive(false);
    }

}
