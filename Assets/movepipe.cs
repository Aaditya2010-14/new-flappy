using UnityEngine;

public class movepipe : MonoBehaviour
{
    public float movespeed;
    float dedzone = -45;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < dedzone)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
    }
}
