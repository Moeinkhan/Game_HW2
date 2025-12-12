using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float _moveSpeed = 5f;
    [SerializeField]
    public float _turnSpeed = 10f;
    public float _gravity = -9.8f;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Input
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(h, 0, v).normalized;

        // Sprint with holding LeftShift
        float currentSpeed = _moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed *= 2;
        }

        // Calculate Movement and Rotation
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, targetAngle, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, rot, Time.deltaTime * _turnSpeed);

            controller.Move(transform.forward * currentSpeed * Time.deltaTime);
        }

        // Gravity
        controller.Move(Vector3.up * _gravity * Time.deltaTime);
    }
}
