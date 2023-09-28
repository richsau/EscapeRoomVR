using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartOver()
    {
        StartCoroutine(StartOverCountDown());
    }


    private IEnumerator StartOverCountDown()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(0);
    }
}