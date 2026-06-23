using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 100f;
    [SerializeField] private Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        // TODO: Cursor'u kilitle (Cursor.lockState = CursorLockMode.Locked)
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // TODO: Mouse X ve Y inputunu oku (Input.GetAxis("Mouse X") ve "Mouse Y")
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        // TODO: mouseX ile playerBody'yi Y ekseninde döndür
        playerBody.Rotate(Vector3.up * mouseX * mouseSensitivity * Time.deltaTime);
        // TODO: mouseY ile kamerayı X ekseninde döndür (xRotation)
        xRotation -= mouseY * mouseSensitivity * Time.deltaTime;
        // TODO: xRotation'ı Clamp ile -90 ve 90 arasında tut
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        // TODO: transform.localRotation'a xRotation'ı uygula
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}