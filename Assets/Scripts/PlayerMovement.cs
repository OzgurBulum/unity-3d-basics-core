using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float gravity = -9.81f;

    private CharacterController controller;
    private Vector3 velocity;

    void Start()
    {
        // TODO: CharacterController component'ini al
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // TODO: Horizontal ve Vertical input oku (Input.GetAxis)
        // TODO: direction hesapla (transform.forward ve transform.right kullan)
        Vector3 direction = transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal");
        // TODO: controller.Move ile hareketi uygula
        controller.Move(direction * moveSpeed * Time.deltaTime);
        // TODO: yerçekimi uygula (velocity.y += gravity * Time.deltaTime)
        velocity.y += gravity * Time.deltaTime;
        // TODO: controller.Move ile velocity'yi de uygula
        controller.Move(velocity * Time.deltaTime);
    }
}