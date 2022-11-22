
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Jump : MonoBehaviour
{
    public GameObject obj; 

    public Transform target;

    public CapsuleCollider capsule;

    public Transform[] transform = new Transform[1];

    public float speed = 5.0f, rotateSpeed = 5.0f;

   

    // Start is called before the first frame update
    void Start()
    {
      
    }

    
    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < transform.Length; i++)
        {
            
            transform[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            transform[i].Rotate(new Vector3(-1, 0, 0) * rotateSpeed * Time.deltaTime);

            //float posX = transform[i].position.x;
            //if(posX == -26)
            //    Destroy(gameObject);
        }

    }

  

}
