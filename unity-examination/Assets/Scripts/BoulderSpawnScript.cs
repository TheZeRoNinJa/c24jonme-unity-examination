using UnityEngine;

public class BoulderSpawnScript : MonoBehaviour
{
    [SerializeField] GameObject boulder;
    
    [SerializeField] Transform boulderSpawnPoint;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(boulder, boulderSpawnPoint.position, boulderSpawnPoint.rotation);
        }
    }
}
