using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject Fireball;
    [SerializeField] float BallSpeed = 1f;
    [SerializeField] float ShootCoolDown = 1f;

    [Header("Debug")]
    [SerializeField] bool CanShootForever = true;

    private float ShootingTimer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShootingTimer += Time.deltaTime;

        SpawnFireballs();
    }

    void SpawnFireballs()
    {
        if (ShootCoolDown <= ShootingTimer && CanShootForever)
        {

            Instantiate(Fireball, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), transform.rotation); //, transform.forward

            //resets the shootingTimer
            ShootingTimer = 0;
        }
    }
}
