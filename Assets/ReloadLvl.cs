using UnityEngine;
using UnityEngine.SceneManagement;




public class ReloadLvl : MonoBehaviour
{
    public static string LastLvl;
    public void Reload()
    {

        SceneManager.LoadScene (LastLvl);

    }

    public static void TryAgain(string Last)
    {

        SceneManager.LoadScene ("Try Again");
        LastLvl = Last;
    }

    
}
