using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField]
    public Image timerBar;
[SerializeField]
    public float timeLeft;
[SerializeField]
    public float timeScale;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeLeft > -1f)
        {
            timeLeft = timeLeft - timeScale * Time.deltaTime;
            timerBar.fillAmount = timeLeft;
        }
    }
}
