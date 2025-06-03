using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball == null) return;

        // Çarpışma noktasındaki yüzeyin normal vektörünü alıyoruz (yüzeyin dik yönü)
        Vector2 normal = collision.GetContact(0).normal;
        // Topa, normalin tersi yönde bir kuvvet uyguluyoruz ki top zıplasın
        ball.AddForce(-normal * bounceStrength);
    }
}