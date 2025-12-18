using UnityEngine;

enum BatmanState
{
    Normal,
    Stealth,
    Alert
}

public class State_Manager : MonoBehaviour
{
    private BatmanState _currentState;
    private Batman_Movement batman_Movement;
    private Light_Manager light_Manager;

    void Start()
    {
        _currentState = BatmanState.Normal;
        batman_Movement = GameObject.Find("Batman").GetComponent<Batman_Movement>();
        light_Manager = GameObject.Find("GameManager").GetComponent<Light_Manager>();
    }

    void Update()
    {
        // Change State
        if (Input.GetKeyDown(KeyCode.N))
            ChangeState(BatmanState.Normal);

        if (Input.GetKeyDown(KeyCode.C))
            ChangeState(BatmanState.Stealth);

        if (Input.GetKeyDown(KeyCode.Space))
            ChangeState(BatmanState.Alert);
    }

    private void ChangeState(BatmanState newState)
    {
        _currentState = newState;

        if (_currentState == BatmanState.Normal)
        {
            batman_Movement.SetNormalSpeed();
            light_Manager.SetNormalLight();

            //if (alertSound.isPlaying)
            //    alertSound.Stop();
        }
        else if (_currentState == BatmanState.Stealth)
        {
            batman_Movement.SetSlowSpeed();
            light_Manager.SetStealthLight();

            //if (alertSound.isPlaying)
            //    alertSound.Stop();
        }
        else if (_currentState == BatmanState.Alert)
        {
            batman_Movement.SetNormalSpeed();
            light_Manager.SetAlertLight();

            //if (!alertSound.isPlaying)
            //    alertSound.Play();
        }
    }
}
