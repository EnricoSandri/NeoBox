using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("Quit");
    }


}