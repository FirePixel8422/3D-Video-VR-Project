using UnityEngine;
using UnityEngine.InputSystem;


public class VRControllerHandler : MonoBehaviour
{
    [SerializeField] private InputActionReference onPress;
    [SerializeField] private Transform pointerTransform;


    private void Awake()
    {
        onPress.action.performed += OnPress;
    }

    private void OnPress(InputAction.CallbackContext ctx)
    {
        if (UIHitTest.ClickUIFromWorld(Camera.main, pointerTransform.position))
        {
            Debug.Log("Hit UI: " + hitUI.name);
        }
    }
    

    private void OnDestroy()
    {
        onPress.action.performed -= OnPress;
    }
}