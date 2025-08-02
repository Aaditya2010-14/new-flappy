using UnityEngine;

public class fly : MonoBehaviour
{
    public Rigidbody2D myRigibody2d;
    public int n;
    public logic logic;
    public bool birdisalive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "bird";
        logic = GameObject.FindGameObjectWithTag("sigma").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdisalive)
        {
            myRigibody2d.linearVelocity = Vector2.up * n;
           
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisalive = false;
    }
}
