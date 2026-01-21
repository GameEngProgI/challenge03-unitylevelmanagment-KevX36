using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject current;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    public GameObject player;
    public GameObject currentLevel;

    public void LevelSwap(GameObject targetLevel, Vector2 spawnPoint)
    {
        currentLevel.gameObject.SetActive(false);
        targetLevel.gameObject.SetActive(true);

        player.transform.position = spawnPoint;
        currentLevel = targetLevel;



    }
}
