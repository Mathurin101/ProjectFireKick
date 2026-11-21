using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour, IDamage
{

    [Header("Stats")]
    [SerializeField] int HP = 3;

    private bool IsHit;
    private bool Kicked;
    private InputAction KickAction;

    private void Awake()
    {
        KickAction = InputManager.instance.GetAction("Kick");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Kicking();
    }


    void Kicking()
    {
        if (KickAction.WasPressedThisFrame())//&& (IsHit || Kicked)
        {
            Debug.Log("Player kicked");

        }
    }

    //-------------IDamage----------------//
    public void TakeDamage(int DamageTaken)
    {
        HP -= DamageTaken;
    }

}
