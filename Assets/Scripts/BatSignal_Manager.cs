using UnityEngine;

public class BatSignal_Manager : MonoBehaviour
{
    private Light batSignal;
    private bool isOn = false;
    private float angle;
    private Vector3 startPosition;

    void Start()
    {
        batSignal = this.GetComponent<Light>();
        batSignal.enabled = false;
        startPosition = transform.position;
    }

    void Update()
    {
        // When press 'B' key
        if (Input.GetKeyDown(KeyCode.B))
        {
            isOn = !isOn;
            batSignal.enabled = isOn;
            // Reset the rotation angle
            angle = 0f;
        }

        // Rotate slowly when it's on
        if (isOn)
        {
            angle += Time.deltaTime;
            float x = Mathf.Cos(angle) * 60;
            float y = Mathf.Sin(angle) * 60;
            transform.position = startPosition + new Vector3(x, y, 0);
        }
    }
}
