using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public AudioClip block;
    AudioSource audioSource;

    private float speed = -12;
    private float deadLine = -10;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
        {
            Debug.Log("isGround is true");
            audioSource.PlayOneShot(block);
        }
       
    }
}
