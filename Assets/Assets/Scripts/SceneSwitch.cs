using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitch : MonoBehaviour
{
    public void SwitchSceneEarth()
    {
        SceneManager.LoadScene("Earth");
    }
    public void SwitchSceneMars()
    {
        SceneManager.LoadScene("Mars");
    }
    public void SwitchSceneHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
