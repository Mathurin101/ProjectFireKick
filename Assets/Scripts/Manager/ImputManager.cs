using UnityEngine;
using UnityEngine.InputSystem;

public class ImputManager : MonoBehaviour
{

    public static ImputManager instance;

    [SerializeField] InputActionAsset InputActions;
    [SerializeField] string ActionMapName;


    private void OnEnable()
    {
        InputActions.FindActionMap(ActionMapName).Enable();
    }
    private void OnDisable()
    {
        InputActions.FindActionMap(ActionMapName).Disable();
    }

    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    public InputAction GetAction(string ActionName)
    {
        return InputActions.FindAction(ActionName);
    }

}
