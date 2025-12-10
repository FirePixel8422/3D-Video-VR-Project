#if UNITY_EDITOR
using Unity.Mathematics;
using UnityEngine;


public class EditorMover : MonoBehaviour
{
    [SerializeField] private float2 rotClamp = 85;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePositionDelta;

            float rotX = transform.localEulerAngles.x - mousePos.y;
            if (rotX > 180) rotX -= 360;

            transform.localRotation = Quaternion.Euler(math.clamp(rotX, rotClamp.x, rotClamp.y), transform.localEulerAngles.y + mousePos.x, 0);
        }
    }
}
#endif