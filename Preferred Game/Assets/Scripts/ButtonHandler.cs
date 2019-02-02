using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    //
    // Try to keep all buttons relatively tidy, add more funtions after the scene selection and before the Start and Update functions.
    //
    /*
     * Scene Order:
     * TESTING SCENE: 0
     * SCENE SELECT: 1
     * KOTH: 2
     * PROP HUNT: 3
     * ZOMBIE: 4
     * 
     */
    public void loadKOTH() //King of the Hill
    {
        SceneManager.LoadScene(2);
    }

    public void loadPropHunt() //Prop Hunt
    {
        SceneManager.LoadScene(3);
    }

    public void loadZombieWaveShooter() //Zombie Wave Shooter
    {
        SceneManager.LoadScene(4);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
