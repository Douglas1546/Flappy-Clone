using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    [SerializeField] float force = 2;
    [SerializeField] int score = 0;
    Rigidbody2D rb;
    public Text scoreView;
    public Transform gameOver;

    int angle;
    int maxAngle = 40;
    int minAngle = -40;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * force;
        }

        if(rb.velocity.y > 0){
            if(angle <= maxAngle){
            angle = angle + 4;
            }
        }
        else if(rb.velocity.y < 0){
            if(angle >= minAngle){
                angle = angle -3;
            }
        }
        transform.rotation = Quaternion.Euler(new Vector3(0,0,angle));
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("AddScore")){
            score++;
            scoreView.text = score.ToString();
        }

        if(collision.CompareTag("Pipe")){
            enabled = false;
            gameOver.gameObject.SetActive(true);
            Invoke("Pause", 2);
        }
    }
    void Pause(){
        Time.timeScale = 0;
    }
}
