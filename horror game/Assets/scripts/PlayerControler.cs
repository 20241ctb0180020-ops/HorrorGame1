using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    public InputActionAsset InputActions;
    private InputAction moveAction;
    public float speed = 20f;
    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }
    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        // float horizontalInput = moveAction.ReadValue<Vector3>().x;
        // transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        // transform.Translate(Vector3.up * speed * Time.deltaTime * horizontalInput);
    }
}
