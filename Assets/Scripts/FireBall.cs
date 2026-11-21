using UnityEngine;

public class FireBall : MonoBehaviour
{
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
        //doesn't hit enemy
        if (other.CompareTag("Enemy"))
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
        }

        Destroy(gameObject);
    }

    void MovingAttack()
    {
        gameObject.GetComponent<Rigidbody>().linearVelocity = transform.forward * 10;
    }
}
