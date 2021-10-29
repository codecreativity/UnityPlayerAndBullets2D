using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float _speed = 1f;

    [SerializeField]
    Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        this._rigidbody.velocity = transform.right * this._speed;
    }

    void Update()
    {
        if(transform.position.x > 10 || transform.position.x < -10 || transform.position.y > 10 || transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Bullet exited the Player");
        this.GetComponent<CircleCollider2D>().isTrigger = false;
    }
}
