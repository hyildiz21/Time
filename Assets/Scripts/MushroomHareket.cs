using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomHareket : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    PlayerKontrol playerKontrol;

    public float MushroomHiz;
    public float rayDist;
    [HideInInspector] public bool isFacingRight;
    public Transform zeminAlgýla;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * MushroomHiz * Time.deltaTime);
        RaycastHit2D groundCheck = Physics2D.Raycast(zeminAlgýla.position, Vector2.down, rayDist);

        if (groundCheck.collider==false)
        {
            if (isFacingRight)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                isFacingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isFacingRight = true;
            }
        }
    }

    




}
