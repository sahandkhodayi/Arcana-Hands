using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float health = 100;
    public Image health_image;
    Rigidbody2D myRig;
    public Animator cam_anim;
    Animator player_anim;
    public float jump_rate, speed;
    public GameObject myCamera;
    public float speed_camera;
    public GameObject umbrella_on, umbrella_off;
    public bool is_jump, live;
    public GameObject background;
    void Start()
    {
        myRig = GetComponent<Rigidbody2D>();
        player_anim = GetComponent<Animator>();
    }

    void Update()
    {
        

        if (health <= 0)
        {
            live = false;
        }
        else 
        {
            live = true;
        }

        health_image.fillAmount = health / 100;

       if (live)
        {
            if (Input.GetKey(KeyCode.Space) || is_jump == true)
            {
                player_anim.SetBool("up", true);
                myRig.linearVelocity = new Vector2(myRig.linearVelocity.x, jump_rate);
                umbrella_on.SetActive(true);
                umbrella_off.SetActive(false);
            }
            else if (is_jump == false)
            {
                player_anim.SetBool("up", false);
                umbrella_off.SetActive(true);
                umbrella_on.SetActive(false);
            }

            transform.Translate(new Vector2(speed * Time.deltaTime,0));
        }

       background.transform.position = new Vector2 (transform.position.x, background.transform.position.y);
       myCamera.transform.position = new Vector3(transform.position.x, myCamera.transform.position.y, myCamera.transform.position.z);

        if (transform.position.y > 0.5f)
        {
            myCamera.transform.position = new Vector3(myCamera.transform.position.x, Mathf.Lerp(myCamera.transform.position.y, 3.4f, speed_camera * Time.deltaTime), myCamera.transform.position.z);
            cam_anim.SetBool("zoom", true);
        }
        else
        {
            myCamera.transform.position = new Vector3(myCamera.transform.position.x, Mathf.Lerp(myCamera.transform.position.y, 0, speed_camera * Time.deltaTime), myCamera.transform.position.z);
            cam_anim.SetBool("zoom", false);
        }
    }

    public void Click_Donw()
    {
        Debug.Log("Click_Donw");
        is_jump = true;
    }

    public void Click_Up()
    {
        Debug.Log("Click_Up");
        is_jump = false;
    }
     
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            health -= 10;
        }
    }


}
