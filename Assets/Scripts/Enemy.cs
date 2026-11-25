using UnityEngine;

public class Enemy : MonoBehaviour
{

    [Header("Stats")]
    [SerializeField] GameObject Fireball;
    [SerializeField] float MinFireBallsCD = 1f;
    [SerializeField] float MaxFireBallsCD = 10f;

    [Header("Debug")]
    [SerializeField] bool CanShootForever = true;
    [SerializeField] int FireBallsPerRound = 10;

    private float ShootingTimer = 0;
    private float ShootCoolDown = 1f;

    private int FireBallCounter = 0;

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
            FireBallCounter++;
            if (FireBallCounter == FireBallsPerRound && (MaxFireBallsCD - 0.1f) > MinFireBallsCD)
            {
                MaxFireBallsCD -= 0.1f;
                Debug.Log("MaxFireBallsCD: " + MaxFireBallsCD);
                FireBallCounter = 0;
            }
            ShootCoolDown = Random.Range(MinFireBallsCD, MaxFireBallsCD);
            Debug.Log("ShootCoolDown: " + ShootCoolDown);
        }
    }

}
