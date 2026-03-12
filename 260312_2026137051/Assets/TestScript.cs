using UnityEngine;

public class TestScript : MonoBehaviour
{
    public string playerName; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("he name is " + playerName);

        Debug.Log("text");
        Debug.LogWarning("Warning text");
        Debug.LogError("Error text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
