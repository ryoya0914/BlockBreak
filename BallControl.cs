using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public GameObject GameClearText;
    public int BlockCount = 10;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        StartCoroutine(StartScene());
        GameClearText.SetActive(false);

    }

    void Update()
    {
        if (BlockCount == 0)
        {
            StartCoroutine("GameClear");
            transform.gameObject.SetActive(false);
        }
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "block")
        {
            BlockCount -= 1;
        }
    }

    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(2);
        rb2d.velocity = new Vector2(6f, 6f);
    }

    IEnumerator GameClear()
    {
        StartCoroutine(MoveScene());
        GameClearText.SetActive(true);
        yield return new WaitForSeconds(2.0f);
    }

    IEnumerator MoveScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("menu");
    }
}
