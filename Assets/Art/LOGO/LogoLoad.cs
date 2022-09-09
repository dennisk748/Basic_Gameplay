using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoLoad : MonoBehaviour
{
    private float duration = 5.0f;
    void Start()
    {
        StartCoroutine(LoadMenu());
    }
    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(duration);

        SceneManager.LoadScene(1);
    }
}
