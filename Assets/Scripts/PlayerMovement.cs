using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public int skor = 0;
    public float kecepatan = 10f;

    private Vector2 arahGerak;

    void OnMove(InputValue value)
    {
        arahGerak = value.Get<Vector2>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            skor += 1;
            Debug.Log("Skor: " + skor);
            FindFirstObjectByType<GameManager>().AmbilKoin();
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        Vector3 arah = new Vector3(arahGerak.x, arahGerak.y, 0);

        transform.position += arah * kecepatan * Time.deltaTime;
    }
}
