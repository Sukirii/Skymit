using UnityEngine;

public class Bat : MonoBehaviour
{
    float speed;
    int leftSide;

    Rigidbody2D rb;
    Transform player;

    public GameObject dieEffect;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>().transform;
    }

    private void Start()
    {
        if (transform.position.x < 0f)
            leftSide = 1;
        else
            leftSide = -1;

        speed = Random.Range(1f, 3.5f);
    }

    private void Update()
    {
        if (transform.position.y < player.position.y - 10f)
            Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(leftSide * speed, 0f);
    }
}