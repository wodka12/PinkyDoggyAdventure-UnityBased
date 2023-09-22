using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0,3)

            // StartCoroutine(PlayOtherAnimation());
        }
    }

    IEnumerator PlayOtherAnimation()
    {
        animator.SetBool("isJumping", true);
        yield return new WaitForSeconds(0.1f); // 3초 동안 대기
        animator.SetBool("isJumping", false);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (Score.score > Score.bestScore){
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
