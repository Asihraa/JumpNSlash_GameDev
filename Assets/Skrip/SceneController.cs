
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public static SceneController instance;

    private void Awake(){
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    public void NextLevel(){
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    } 

    public void LoadScene(string sceneName){
        SceneManager.LoadSceneAsync(sceneName);
    }
}
