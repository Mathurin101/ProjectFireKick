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

    public void SetActionMapName(string MapName)
    {
        ActionMapName = MapName;
    }

    public InputAction GetAction(string ActionName)
    {
        return InputActions.FindActionMap(ActionMapName).FindAction(ActionName);
    }

}
