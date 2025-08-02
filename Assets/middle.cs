
using UnityEngine;
using UnityEngine.UIElements;

public class middle : MonoBehaviour
{

    public logic logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("sigma").GetComponent<logic>();
        if (logic == null)
        { Debug.LogError("Logic component not found!"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered with: " + collision.name);
        logic.Score();
     

    }
}
