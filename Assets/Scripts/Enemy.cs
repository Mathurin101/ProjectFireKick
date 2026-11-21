using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject Fireball;
    [SerializeField] float BallSpeed = 1f;
    [SerializeField] float ShootCoolDown = 1f;


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
        if (ShootCoolDown <= ShootingTimer)
        {
            Instantiate(Fireball, transform); //, transform.forward

            //resets the shootingTimer
            ShootingTimer = 0;
        }
    }
}
