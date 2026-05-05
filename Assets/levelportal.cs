using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinisher : MonoBehaviour

{
    public string lvlToOpen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(lvlToOpen);
    }




}