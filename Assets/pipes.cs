using UnityEngine;

public class pipes : MonoBehaviour
{
    public GameObject pipe;
    public float  Spawnrate = 2;
    private float timer = 0;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Spawnrate)
        {
            timer  = timer + Time.deltaTime;
            
        }
        else 
        {
            make();
            timer = 0;
        }

        
    }

    void make()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(5,-5), 0), transform.rotation);
       
    }
}
