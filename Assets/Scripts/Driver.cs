using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] TextMeshProUGUI textMesh;

    void Start()
    {
        textMesh.enabled = false;
    }
    void Update()
    {
        MoveCar();
    }

    private void MoveCar()
    {
        float steer = 0f;
        float move = 0f;
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }

        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }
        
        float steerAmount = steer * steerSpeed * Time.deltaTime;
        float moveAmount = move * moveSpeed * Time.deltaTime;
        
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    
    public void SetSpeed(float speedAmount)
    {
        moveSpeed = speedAmount;
        textMesh.enabled = speedAmount > 5f;
    }
}
