using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour, IDamage
{

    [Header("Stats")]
    [SerializeField] int HP = 3;
    [SerializeField] float kickBoxDuration = 1.6f;


    [Header("GameObjects")]
    [SerializeField] GameObject KickBox;
    [SerializeField] TextMeshProUGUI HPDisplay;

    private bool IsHit = false;
    private bool HasKicked = true;
    private InputAction KickAction;

    private void Awake()
    {
        KickAction = InputManager.instance.GetAction("Kick");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        KickBox.SetActive(false);
        HPDisplay.text = HP.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        Kicking();

    }


    void Kicking()
    {
        if (KickAction.WasPressedThisFrame() && (IsHit || HasKicked))
        {
            // Debug.Log("Player kicked");
            Debug.Log("Kick is " + InputManager.instance.GetActionName(KickAction));

            //make the hit box active
            KickBox.SetActive(true);

            //check to see if it hit the fire ball
            HasKicked = KickBox.GetComponent<KickBoxAction>().ItHitBall;
            IsHit = false;
            StartCoroutine(MakeKickActive());
        }
    }

    //-------------IDamage----------------//
    public void TakeDamage(int DamageTaken)
    {
        HP -= DamageTaken;
        IsHit = true;

        HPDisplay.text = HP.ToString();
    }

    IEnumerator MakeKickActive()
    {
        yield return new WaitForSeconds(kickBoxDuration);
        KickBox.SetActive(false);
    }
}
