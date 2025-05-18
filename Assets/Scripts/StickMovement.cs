using Unity.Collections;
using UnityEngine;

public class StickMovement : MonoBehaviour
{
    public Watch watch;
    public float speed = 5;
    public int facingdirection = 1;
    public Rigidbody2D rb;
    public Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (watch.watchOn == false)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            if (horizontal > 0 && transform.localScale.x < 0 ||
               horizontal < 0 && transform.localScale.x > 0)
            {
                Flip();
            }

            anim.SetFloat("horizontal", Mathf.Abs(horizontal));
            anim.SetFloat("vertical", Mathf.Abs(vertical));
            rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
        } else
        {
            rb.linearVelocity = Vector2.zero;
            Debug.Log("watch is on");
        }
 
    }
    void Flip()
    {
        facingdirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
