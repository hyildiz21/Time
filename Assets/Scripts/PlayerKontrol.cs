using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKontrol : MonoBehaviour
{

    PlayerStats playerStats;

    Rigidbody2D rb2d;
    Animator animator;
    Vector3 velocity;

    [SerializeField] float hiz;
    [SerializeField] float hizlanma;
    [SerializeField] float yavaslama;
    [SerializeField] float ZiplamaGucu;
    //istersek editörden de ayarlayabiliriz
    float ziplamaLimiti = 3;
    float ziplamaSayisi;

    bool canAttack;
    bool hareketEt=true;

    

    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 5f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;
    [SerializeField] private TrailRenderer tr;

    public bool Hareket
    {
        get
        {
            return hareketEt;
        }
        set
        {
            hareketEt = value;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hareketEt)
        {
            CassieHareket();
            
           
        }
        


        if (Input.GetKeyDown(KeyCode.E) && canDash) //
        {
            FindObjectOfType<SesKontrol>().DashSes();
            StartCoroutine(Dash());
        }
    }
    /// <summary>
    /// oyun sonlanýnca tet in hareketi durucak bunu bool ile yaptým ama fonksiyon ile çaðýrdým oyunkontrol sciriptinde oyunBitir metodunda
    /// </summary>
    public void HareketEdemez()
    {
        hareketEt = false;
    }
   
    

    public void CassieHareket()
    {
        
        float yatayInput = Input.GetAxisRaw("Horizontal");
        Vector2 scale = transform.localScale;

        if (yatayInput < 0)
        {
            
            velocity.x = Mathf.MoveTowards(velocity.x, yatayInput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("Run", true);
            scale.x = -6;

        }

        if (yatayInput > 0)
        {
            
            velocity.x = Mathf.MoveTowards(velocity.x, yatayInput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("Run", true);
            scale.x = 6;
        }

        if (yatayInput == 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, yavaslama * Time.deltaTime);
            animator.SetBool("Run", false);
        }

        if (Input.GetKeyDown("space"))
        {
            ZiplamaBaslat();
        }

        if (Input.GetKeyUp("space"))
        {
            ZiplamaDurdur();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            FindObjectOfType<SesKontrol>().SaldiriSes();
            animator.SetTrigger("Attack");
        }

        

        transform.Translate(velocity * Time.deltaTime);
        transform.localScale = scale;

    }

    public void ZiplamaBaslat()
    {
        if (ziplamaSayisi < ziplamaLimiti)
        {
            FindObjectOfType<SesKontrol>().ZiplamaSes();
            rb2d.AddForce(new Vector2(0, ZiplamaGucu), ForceMode2D.Impulse);
            ziplamaSayisi++;
            animator.SetBool("Jump", true);
            FindObjectOfType<SliderKontrol>().sliderDeger(ziplamaLimiti, ziplamaSayisi);
        }
    }

    public void ZiplamaDurdur()
    {
        animator.SetBool("Jump", false);
        FindObjectOfType<SliderKontrol>().sliderDeger(ziplamaLimiti, ziplamaSayisi);
    }

    /// <summary>
    /// dýþardan ulaþarak cassie nin tekrar zýplamasýný saðlayacak ontrigger metodunda
    /// </summary>
    public void ZiplamaSifirla()
    {
        ziplamaSayisi = 0;
        FindObjectOfType<SliderKontrol>().sliderDeger(ziplamaLimiti, ziplamaSayisi);
    }





    private void FixedUpdate() //
    {
        if (isDashing)
        {
            return;
        }


    }

    private IEnumerator Dash() //
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb2d.gravityScale;
        rb2d.gravityScale = 0f;
        rb2d.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb2d.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }

}
