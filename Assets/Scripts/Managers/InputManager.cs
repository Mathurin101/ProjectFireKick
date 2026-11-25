using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    [SerializeField] InputActionAsset InputActions;
    [SerializeField] string ActionMapName;

    //used to clear the memory that was allocated to the Inputaction
    private InputActionRebindingExtensions.RebindingOperation RebindOperationCache;

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

    public void SwitchActionMapName(string MapName)
    {
        ActionMapName = MapName;
    }

    public InputAction GetAction(string ActionName)
    {
        return InputActions.FindActionMap(ActionMapName).FindAction(ActionName);
    }

    public string GetActionName(InputAction InputtedAction)
    {
        InputActionReference inputActionRef = InputActionReference.Create(InputtedAction);

        //get the current index of the controlls the player is currently using which will be at zero
        int BindindIndex = inputActionRef.action.GetBindingIndexForControl(inputActionRef.action.controls[0]);

        return InputControlPath.ToHumanReadableString(inputActionRef.action.bindings[BindindIndex].effectivePath,
        InputControlPath.HumanReadableStringOptions.OmitDevice);//will get the letter of the key/controls
    }

    public string GetActionName(InputActionReference InputtedActionRef)
    {
        //get the current index of the controlls the player is currently using which will be at zero
        int BindindIndex = InputtedActionRef.action.GetBindingIndexForControl(InputtedActionRef.action.controls[0]);

        return InputControlPath.ToHumanReadableString(InputtedActionRef.action.bindings[BindindIndex].effectivePath,
        InputControlPath.HumanReadableStringOptions.OmitDevice);//will get the letter of the key/controls
    }

    public void StartRebinding(InputActionReference InputtedAction)
    {
        //RebindOperationCache = InputtedAction.action.performinteractiveRebinding()
        //.withControllsExcluding("Mouse")// listen to everything besides mouse input
        //.OnMatchWaitForAnother(0.1f) //a timer to wait just in case 
        //.OnComplete(Operation => OnRebindComplete()) // when the rebinding is done it will run the method in the lambda
        //.start() //to make all of the previous things occur;
    }
    public void StartRebinding(InputAction InputtedAction)
    {
        //InputActionReference inputActionRef = InputActionReference.Create(InputtedAction);

        //RebindOperationCache = InputtedAction.action.performinteractiveRebinding()
        //.withControllsExcluding("Mouse")// listen to everything besides mouse input
        //.OnMatchWaitForAnother(0.1f) //a timer to wait just in case 
        //.OnComplete(Operation => OnRebindComplete()) // when the rebinding is done it will run the method in the lambda
        //.start() //to make all of the previous things occur;
    }

    //void OnRebindComplete()
    //{
    //RebindOperationCache.dispose();
    //}



}
