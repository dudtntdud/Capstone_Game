using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class csHero : MonoBehaviour {
    public float speed = 5.0f;
    public float jumpPower = 0.1f;

    bool isJumping;

    Rigidbody2D rigidbody;

    Vector2 movement;

   // private csGameManager csgamemanager;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        isJumping = false;
    }

    void Update() {

        if (this.transform.position.x <= 45.0f)
            this.transform.Translate(new Vector3(0.05f, 0, 0));  //이동

        if (Input.GetButton("Jump") && isJumping == false)
        {
            isJumping = true;
            Jump();
        }

        if (transform.position.y <= -3.0f)
        {
            Destroy(this.gameObject);
            Application.Quit();
            //csGameManager.GameOver();
        }

    }


    void Jump()
    {
        rigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        //rigidbody.velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpPower);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coins")
        {
            Destroy(col.gameObject);
            csGameManager.score += 10;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            isJumping = false;
        }
        else if (col.gameObject.tag == "Obstacle" && !csGameManager.isUnBeatTime)
        {
            Debug.Log("hi");
            csGameManager.hp--;
            col.collider.isTrigger = true;
            this.transform.Translate(new Vector3(-1.0f, 1.0f, 0));
           
            if (csGameManager.hp > 1)
            {
                csGameManager.isUnBeatTime = true;
                StartCoroutine("UnBeatTime");
            }
        }
    }

    IEnumerator UnBeatTime()
    {
        int countTime = 0;

        while (countTime < 10)
        {
            if (countTime % 2 == 0) spriteRenderer.color = new Color32(255, 255, 255, 90);
            else spriteRenderer.color = new Color32(255, 255, 255, 180);

            yield return new WaitForSeconds(0.2f);

            countTime++;
        }

        spriteRenderer.color = new Color32(255, 255, 255, 255);

        csGameManager.isUnBeatTime = false;

        yield return null;
    }
}