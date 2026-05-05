using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class KillVolume : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
