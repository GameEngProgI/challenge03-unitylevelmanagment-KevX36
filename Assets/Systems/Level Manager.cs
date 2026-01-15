using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject current;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    
    public GameObject lv1;
    public GameObject lv2;
    
    public void LevelSwap()
    {
        lv1.gameObject.SetActive(false);
        lv2.gameObject.SetActive(true);






    }
}
