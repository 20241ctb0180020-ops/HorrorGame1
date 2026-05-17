using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public Transform player; // Objeto que a câmera vai seguir
    public Vector3 offset;   // Distância inicial da câmera
    public float mouseSensitivity = 500f;
    
    void Update()
    {
        // Rotação da câmera com base no movimento do mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        transform.RotateAround(player.position, Vector3.up, mouseX);
        transform.RotateAround(player.position, transform.right, -mouseY);

        // Movimento de seguir o player
        transform.position = player.position + offset;
    }
}
