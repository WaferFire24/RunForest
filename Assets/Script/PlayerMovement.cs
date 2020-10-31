using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D myControler;
    public Animator animator;
    AudioSource jumpsound;

    private float pergerakanX;

    public float kecepatanBergerak;
    private bool isJump = false;
	private bool isSneak = false;
    private bool isSit = false;


    void Start()
    {
        jumpsound = GetComponent<AudioSource>();
    }

        void Update()
    {
        pergerakanX = Input.GetAxisRaw("Horizontal") * kecepatanBergerak;

        animator.SetFloat("Velocity", Mathf.Abs(pergerakanX));

        if (Input.GetButtonDown ("Jump")) { 
			isJump = true;
            animator.SetBool("Jumpping", true);
            jumpsound.Play();
		} 

        if (Input.GetButtonDown ("Sneak")) 
        {
			isSneak = true;
        } 
        else if (Input.GetButtonUp ("Sneak")) 
        {
			isSneak = false;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            isSit = true;
            animator.SetBool("Sitting", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            isSit = false;
            animator.SetBool("Sitting", false);
        }

        if (GetComponent<Transform>().position.y <= -5f){
            FindObjectOfType<GameManager>().GameEnded();
        }  
    }

    public void OnLanding(){
       animator.SetBool("Jumpping", false);
    }

    public void onCrouching(bool isCrouching){
        animator.SetBool("Sneaking", isCrouching);
    }

    void FixedUpdate() {
        myControler.Move (pergerakanX * Time.fixedDeltaTime, isSneak, isJump, isSit);
		isJump = false;
        animator.SetBool("Jumpping", false);
    } 
}
