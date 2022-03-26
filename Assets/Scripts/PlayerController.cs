using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float jumpForce = 2f;
    [SerializeField] float HP = 100f;

    public Scrollbar ScrollbarHP;
 
    private readonly Vector3 jumpDirection = Vector3.up;
    public bool isGround { get; private set; }
    private new Rigidbody rigidbody;



    private void Start()
    {
        this.rigidbody = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetInput();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    
    }
    void Jump()
    { if (this.isGround)
            this.rigidbody.AddForce(this.jumpDirection * this.jumpForce, ForceMode.Impulse);
                  
    }
    private void OnCollisionEnter(Collision other)
    {
        var ground = other.gameObject.GetComponentInParent<ground>();
        if (ground)
            this.isGround = true;
    }

    private void OnCollisionExit(Collision other)
    {
        var ground = other.gameObject.GetComponentInParent<ground>();
        if (ground)
            this.isGround = false;
    }

    private void GetInput()
    {
        #region KeyController
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
        #endregion
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Barbed")
        {
            HP -= 10f;
            ScrollbarHP.size = HP;
            if (HP < 1f)
            {
                Death();
            }
        }

        if (other.gameObject.tag == "Zombie")
        {
            HP -= 25f;
            ScrollbarHP.size = HP;
            if (HP < 1f)
            {
                Death();
            }
        }
    }

    private void Death()
    {
        
        Destroy(gameObject);
        Debug.Log("Death");
    }


}
