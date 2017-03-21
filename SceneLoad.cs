using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoad : MonoBehaviour
{

	void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}

    public void StartScene()
    {
        SceneManager.LoadScene("main");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("menu");
    }
}
