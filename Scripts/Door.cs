using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private int playerInside=0;
    private bool levelLoading = false;
    public GameObject player1;
    public GameObject player2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("player 1") || other.CompareTag("player 2")){
            playerInside++;
            if(playerInside ==2){
                levelLoading = true;
                Invoke("LoadNext" , 1f);
                player1.SetActive(false);
                player2.SetActive(false);
            }
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("player 1") || other.CompareTag("player 2")){
            playerInside--;
        }
    }
    void LoadNext(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
