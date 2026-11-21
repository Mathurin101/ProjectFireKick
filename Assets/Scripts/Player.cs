using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    private InputAction KickAction;

    private void Awake()
    {
        KickAction = ImputManager.instance.GetAction("Kick");
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
        if (KickAction.WasPressedThisFrame())
        {
            Debug.Log("Player kicked");

        }
    }
}
