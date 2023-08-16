using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    protected Rigidbody rb;
    protected Vector3 _forcesPosition;
    [Tooltip("—тартова€ позици€ м€чика")]
    [SerializeField] Vector3 _startPosition;
    [Tooltip("—ила стартого толчка м€чика. ƒл€ начала игры нажмите SPACE!")]
    [SerializeField] private float _forceBall;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {       
        _startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        _forcesPosition = rb.velocity;

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * _forceBall);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        var speed = _forcesPosition.magnitude;
        var direction = Vector3.Reflect(_forcesPosition.normalized, collision.contacts[0].normal);
        rb.velocity = Mathf.Max(speed, 0f) * direction;
    }
    private void OnTriggerEnter(Collider other)
    {
        transform.position = _startPosition;
    }
}

