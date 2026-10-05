using UnityEngine;

public class Movement : MonoBehaviour
{
    public int MovementSpeed = 2000;
    public int JumpForce = 200;
    private bool TouchingFloor = false;
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime * MovementSpeed,
            0,
            Input.GetAxis("Vertical") * Time.deltaTime * MovementSpeed
        ));

        if (Input.GetKeyDown(KeyCode.Space) && TouchingFloor)
        {
            TouchingFloor = false;
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,JumpForce,0), ForceMode.Impulse);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor")){
            TouchingFloor = true;
        }
    }
}