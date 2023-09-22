using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    // Start is called before the first frame update
    private Animator animator;
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
            ReplayOtherAnimation();
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0,3)
        }
    }

    void PlayOtherAnimation()
    {
        animator.SetBool("isJump", false);
    }

    void ReplayOtherAnimation()
    {
        animator.Play("DogJump", -1, 0f); // "DogJump" 애니메이션을 처음부터 재생
        animator.SetBool("isJump", true);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (Score.score > Score.bestScore){
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
