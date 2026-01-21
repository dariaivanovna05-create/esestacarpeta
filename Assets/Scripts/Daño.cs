using UnityEngine;

public class Daño : MonoBehaviour
{
    [SerializeField] private float velocidad = 6f;
    [SerializeField] private int Damage = 0;
    [SerializeField] private float KnockbackF = 0;
    [SerializeField] private float StunDuration = 0;
    [SerializeField] private Transform PositionPlayer;
    [SerializeField] private Vector2 Direccion;
    [SerializeField] private float Gravedad = 0f;
    [SerializeField] private string Tipo;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, PositionPlayer.position, velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DestruirEnemigo();
            collision.gameObject.GetComponent<PlayerManager>().TakeDamage(Damage, Direccion, KnockbackF, StunDuration);
        }
    }
  
    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = Gravedad;
    }

    private void DestruirEnemigo()
    {
        Destroy(gameObject);
    }

    private void Pelea()
    {
        if (Tipo == "T")
        {

        }

        else if (Tipo == "C")
        {

        }

        else if (Tipo == "R")
        {
          
        }
    }

}
