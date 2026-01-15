using JetBrains.Annotations;
using UnityEngine;

public class LevelChange : MonoBehaviour
{

    public LevelManager LevelManager;

    private void Start()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("left");

            LevelManager.LevelSwap();

        }


    }
    









}
