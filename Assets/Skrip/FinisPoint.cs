using UnityEngine;

public class FinisPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player"))

        //Go next Level
        SceneController.instance.NextLevel();
    }   
    

}
