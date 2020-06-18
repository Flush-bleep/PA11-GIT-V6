using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;

    public float score = 0;

    public Text displayScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        transform.position = new Vector3((transform.position.x), Mathf.Clamp(transform.position.y, -3.9f, 3.9f), transform.position.z);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            //print("asda");
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Point")
        {
            score += 10;
            displayScore.text = "Score: " + score;
        }
    }

}
