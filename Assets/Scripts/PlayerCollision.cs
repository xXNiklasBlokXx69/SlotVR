using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.name == "door_scene1")
        {
            Debug.Log("Collsion works");
            SceneManager.LoadScene("scene2");
        }
        
        if(hit.gameObject.name == "Cube-yellow")
        {
            Debug.Log("Collsion works");
            SceneManager.LoadScene("scene1");
        }
    }
    
}
