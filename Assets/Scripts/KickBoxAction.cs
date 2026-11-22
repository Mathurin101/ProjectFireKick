using UnityEngine;

public class KickBoxAction : MonoBehaviour
{
    public bool ItHitBall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            ItHitBall = true;
            GameManager.instance.IncreaseFireKickedCounter();
        }
    }
}
