using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    void FixedUpdate()
    {
        if (ball.velocity.x > 0.0f)
            FollowBall();
        else
            MoveToCenter();
    }

    void FollowBall()
    {
        if (ball.position.y > transform.position.y)
            rb.AddForce(Vector2.up * speed);
        else if (ball.position.y < transform.position.y)
            rb.AddForce(Vector2.down * speed);
    }

    void MoveToCenter()
    {
        if (transform.position.y > 0.0f)
            rb.AddForce(Vector2.down * speed);
        else if (transform.position.y < 0.0f)
            rb.AddForce(Vector2.up * speed);
    }
}