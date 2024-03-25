using UnityEngine;

public class moveBall : MonoBehaviour
{
    Rigidbody rigidbody;

    public float speed = 0f;

    public float jumpForce = 9;
    public AudioSource audioSource;
    public AudioSource fallSource;
    public AudioSource colisionSource;
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

        float xDirection = Input.GetAxis("Horizontal"); //������ �����
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * speed; //��� �'�����
        rigidbody.AddForce(moveDirection * speed); //����������� �'�����

        if (Input.GetButtonDown("Jump") && isBallOnGround) //�������
        {
            rigidbody.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            isBallOnGround = false;
            audioSource.Play();
            Debug.Log("Ball was jumped");
        }
    }
    private void OnCollisionEnter(Collision collision) //�� ���� ��������� �� �������
    {
        //Debug.Log("In colision method");
        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("changed to true");
            isBallOnGround = true;
        }
        if(collision.gameObject.tag == "Lava")
        {
            fallSource.Play();
        }
        colisionSource.Play();
    }
    private void OnCollisionExit(Collision collision) //�� ���� �������� �� ����� ��������� �� false ��� ����� �� �������� (Bouncy)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("jumped from plain");
            isBallOnGround = false;
        }
    }
}
