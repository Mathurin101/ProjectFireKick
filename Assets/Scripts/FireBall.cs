using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] int Damage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        MovingAttack();
    }

    private void OnTriggerEnter(Collider other)
    {
        //doesn't hit enemy or self
        if (other.CompareTag("Enemy") || other.CompareTag("Projectile"))
        {
            return;
        }

        //if it touches the kick
        if (other.CompareTag("Kick"))
        {
            Debug.Log("it touched the kick");

        }

        //if it touches the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("it touched the player");

            IDamage PlayerHP = other.GetComponent<IDamage>();

            PlayerHP.TakeDamage(Damage);
        }

        Destroy(gameObject);
    }

    void MovingAttack()
    {
        gameObject.GetComponent<Rigidbody>().linearVelocity = transform.forward * 10;
    }
}
