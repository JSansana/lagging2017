using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    
    public GameObject fragment;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        
        //Create_fragments(4);
    }

    public void Create_fragments(int n)
    {
        for (int i = 0; i < n; i++)
        {
            GameObject frag = Instantiate(fragment, transform.position, fragment.transform.rotation);
            Rigidbody2D rb = frag.GetComponent<Rigidbody2D>();
            float randomX = Random.Range(-500, 700);
            float randomY = Random.Range(300, 500);
            Vector2 direc = new Vector2(randomX, randomY);
            rb.AddForce(direc);
            Destroy(frag, 5);
        }
        
        
    }
}
