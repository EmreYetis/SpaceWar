using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public static int count = 10;
    public GameObject Enemy;
    
    TextMeshProUGUI countText;

    void Start()
    {
        Enemy = GameObject.Find("Enemy");
        countText = GetComponent<TextMeshProUGUI>();
        countText.text = "Count : " + count;
    }

    // Update is called once per frame
    void Update()
    {       
        if (Enemy.transform.position.x <= -29f)
        {
            updateScore(1);
        }
    }
    
    public void updateScore(int minus)
    {        
        count -= minus;
        countText.text = "Count : " + count;
    }
}
