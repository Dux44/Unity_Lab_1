using UnityEngine;

public class moveBall : MonoBehaviour
{
    Rigidbody rigidbody;

    public float speed = 0f;

    public float jumpForce = 9;
    private bool isBallOnGround = true;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
    }
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
    private void PlayerMove()
    {

        float xDirection = Input.GetAxis("Horizontal"); //≥гноруЇ кол≥з≥ю
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * speed; //рух м'€чика
        rigidbody.AddForce(moveDirection * speed); //прискоренн€ м'€чика

        if (Input.GetButtonDown("Jump") && isBallOnGround) //стрибок
        {
            rigidbody.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            isBallOnGround = false;
            Debug.Log("Ball was jumped");
        }
    }
    private void OnCollisionEnter(Collision collision) //це коли торкнувс€ до поверхн≥
    {
        //Debug.Log("In colision method");
        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("changed to true");
            isBallOnGround = true;
        }
    }
    private void OnCollisionExit(Collision collision) //це коли в≥дскочив в≥н зм≥нюЇ прапорець на false щоб знову не пригнути (Bouncy)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("jumped from plain");
            isBallOnGround = false;
        }
    }
}
