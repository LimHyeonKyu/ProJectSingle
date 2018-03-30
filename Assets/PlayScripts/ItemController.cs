using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

    public Vector2 tarPos;
    public Vector2 playPos;
    public GameObject player;
    public float speed;
    void Start()
    {
        player = GameObject.Find("Player1");
        Physics.gravity = new Vector3(0, -5f, 0);
        GetComponent<Rigidbody>().AddForce(Random.Range(-40,40),Random.Range(80,90),0);
    }
	void Update ()
    {
        playPos = player.transform.position;
        tarPos = this.transform.position;
        float distance = Vector2.Distance(playPos,tarPos);
        if(player.GetComponent<PlayerScript>().magnetics==true)
        {
            if(distance<0.32f)
            {
                float degree =Mathf.Atan2(playPos.y - tarPos.y, playPos.x - tarPos.x) * 180f / Mathf.PI;
                transform.rotation = Quaternion.Euler(0, 0, degree + 90f);
                transform.Translate(playPos *speed*Time.deltaTime);
            }
        }
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
        if(transform.position.x <-0.5f)
        {
            transform.position = new Vector3(-0.5f, transform.position.y, -0.1f);
        }
        if (transform.position.x > 0.5f)
        {
            transform.position = new Vector3(0.5f, transform.position.y, -0.1f);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
    }
}
