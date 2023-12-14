using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem runningDust;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    
    private AudioSource playerAudio;
    public float jumpForce = 12.0F;
    public float doubleJumpForce = 2000.0F;
    public float gravityModifier = 1.8F;
    public bool isOnGround = true;
    public bool gameOver;
    public bool doubleJump = false;

    private GameManager gameManager;
    private MoveLeft goLeft;




    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;


        gameManager = GameObject.Find("SpawnManager").GetComponent<GameManager>();
        goLeft = GameObject.Find("Background").GetComponent<MoveLeft>();



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround )
        {
            if (goLeft.isFast)
            {
                gameManager.UpdateScore(6);
            
            }
            if (!goLeft.isFast)
            {
                gameManager.UpdateScore(3);

            }
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            runningDust.Stop();
            playerAudio.PlayOneShot(jumpSound);
           
            doubleJump = false;

        }
        else if (Input.GetKeyDown(KeyCode.Space) && !isOnGround && !doubleJump)
        {
            doubleJump = true;
            playerRb.AddForce(Vector3.up * doubleJumpForce, ForceMode.Impulse);
            playerAnim.Play("Running_Jump", 3, 0f);
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

        


    }

   

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            runningDust.Play();
            

        }
        else if (collision.gameObject.CompareTag("Obstacles"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            isOnGround = false;
            runningDust.Stop();
            playerAnim.SetTrigger("Death_b");
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound,3.0F);

        }
        
    
    }
}
