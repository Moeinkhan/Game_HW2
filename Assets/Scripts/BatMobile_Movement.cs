using UnityEngine;

public class BatMobile_Movement : MonoBehaviour
{
    private float _speed = 50f;
    private float _turnSpeed = 60f;
    public bool isDriving = false;

    void Update()
    {
        if (!isDriving)
            return;

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.up * v * _speed * Time.deltaTime);
        transform.Rotate(Vector3.forward * h * _turnSpeed * Time.deltaTime);
    }
}
