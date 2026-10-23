using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    //public float velocidad = 8f;
    public float fuerza = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            rb.AddForce(Vector2.up * fuerza * rb.mass * Time.deltaTime, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            rb.AddForce(Vector2.left * fuerza * rb.mass * Time.deltaTime, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            rb.AddForce(Vector2.down * fuerza * rb.mass * Time.deltaTime, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            rb.AddForce(Vector2.right * fuerza * rb.mass * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}
