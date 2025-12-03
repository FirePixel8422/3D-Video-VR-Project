using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{
    [SerializeField] private InputActionProperty controllerPosition;
    [SerializeField] private InputActionProperty controllerRotation;


    private void Update()
    {
        transform.SetPositionAndRotation(controllerPosition.action.ReadValue<Vector3>(), controllerRotation.action.ReadValue<Quaternion>());
    }
}
