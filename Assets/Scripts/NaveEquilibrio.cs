using UnityEngine;

public class NaveEquilibrio : MonoBehaviour
{
    public float fuerza = 8f;

    private Rigidbody2D rb;

    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            spriteRenderer.color = Color.red;
        }
        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.color = Color.orange;
        }
        if (Input.GetKey(KeyCode.S))
        {
            spriteRenderer.color = Color.yellow;
        }
        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.color = Color.orange;
        }
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direccion = new Vector2(
            horizontal,
            vertical
        );

        rb.AddForce(direccion * fuerza);
    }
}