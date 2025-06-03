using UnityEngine;

public class Ball : MonoBehaviour
{
  private Rigidbody2D rb;
  public float speed = 200.0f;

  private void Awake()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  private void Start()
  {
    LaunchBall();
  }

  private void LaunchBall()
  {
    float x = Random.value < 0.5f ? -1f : 1f;
    // y yönü rastgele, ama tamamen düz olmasın diye sınırlandırıldı.
    // 0.5'ten küçükse -1 ile -0.5 arası (aşağı), büyükse 0.5 ile 1 arası
    float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

    Vector2 direction = new Vector2(x, y).normalized;
    rb.AddForce(direction * speed);
  }

  public void AddForce(Vector2 force)
  {
    rb.AddForce(force);
  }

  public void ResetPosition()
  {
    rb.velocity = Vector2.zero;
    rb.position = Vector2.zero;
    LaunchBall();
  }
}