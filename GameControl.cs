using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public bool Stop;
    public GameObject ball;
    public GameObject GameOverText;

    void Start()
    {
        GameOverText.SetActive(false);
    }

    void Update()
    {
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject)
        {
            StartCoroutine("GameOver");
            ball.SetActive(false);
            if (Stop == true)
            {
                ball.SetActive(false);
                Stop = false;

            }
            else
            {
                ball.SetActive(true);
                Stop = true;
            }



        }
    }


    IEnumerator GameOver()
    {
        StartCoroutine(MoveScene());
        GameOverText.SetActive(true);
        yield return new WaitForSeconds(2.0f);
    }

    IEnumerator MoveScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("menu");
    }
}
