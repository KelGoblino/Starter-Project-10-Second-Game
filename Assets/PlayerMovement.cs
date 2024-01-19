using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public LevelManager fail;
    public float speed;
    private float Move;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fail = GameObject.FindGameObjectWithTag("Fail").GetComponent<LevelManager>();

    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(rb.velocity.x, Move * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fail.changeScene();
    }
}