using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactionRange = 3f;
    [SerializeField] private KeyCode interactKey = KeyCode.E;

    void Update()
    {
        // TODO: Physics.Raycast ile kameradan ileri yönde ray at
        // TODO: ray bir objeye çarparsa hit.collider.gameObject'i al
        // TODO: E tuşuna basılırsa Interact(hit.collider.gameObject) çağır
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, interactionRange))
        {
            if (Input.GetKeyDown(interactKey))
            {
                Interact(hit.collider.gameObject);
            }
        }
    }

    private void Interact(GameObject obj)
    {
        // TODO: objenin ismini Debug.Log ile yazdır
        Debug.Log(obj.name);
        // TODO: objenin ismi "Door" ise kapıyı aç (rotation değiştir)
        if (obj.name == "Door")
        {
            obj.transform.Rotate(0f, 90f, 0f);
        }
        // TODO: objenin ismi "InteractableObject" ise rengini değiştir
        if (obj.name =="InteractableObject")
        {
            obj.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}