using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharController : MonoBehaviour
{

    private Rigidbody r;
    public float mH = 10;
    public float jumpHeight = 16000;
    public float gravitySpeed = 1000;
    public float curHeight;
    public bool canJump;
    public GameObject lightning;

    void Start()
    {
        r = GetComponent<Rigidbody>();
        lightning.SetActive(false);
    }
    void Update()
    {
        curHeight = transform.position.y;
        if (canJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space");
                r.AddForce(transform.up * jumpHeight * Time.deltaTime);
                canJump = false;
            }
        }
        transform.position = new Vector3(Camera.main.transform.position.x, curHeight, 9.31f);

        if (Input.GetMouseButton(0))
        {
            lightning.SetActive(true);
        }
        else
        {
            lightning.SetActive(false);
        }
    }
    void LateUpdate()
    {
        r.AddForce(-transform.up * gravitySpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Floor")
        {
            canJump = true;
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "DeathZone")
        {
            SceneManager.LoadSceneAsync("InfiniteRunner");
        }
    }
}
