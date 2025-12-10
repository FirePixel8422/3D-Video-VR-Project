using UnityEngine;
using UnityEngine.InputSystem;


public class HandOffsetHandler : MonoBehaviour
{
    [SerializeField] private InputActionProperty headPosition;
    [SerializeField] private InputActionProperty ControllerPosition;

    private Vector3 baseOffset;
    public float y;
    public float y2;


    private void Start()
    {
        baseOffset = transform.localPosition;
    }

    private void Update()
    {
        Vector3 headPos = new Vector3(0, headPosition.action.ReadValue<Vector3>().y, 0);
        y = headPosition.action.ReadValue<Vector3>().y;
        y2 = ControllerPosition.action.ReadValue<Vector3>().y;

        transform.localPosition = baseOffset + headPos;
    }
}
