using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    /*
     * Scene Order:
     * TESTING SCENE: 0
     * SCENE SELECT: 1
     * KOTH: 2
     * PROP HUNT: 3
     * ZOMBIE: 4
     * 
     * */
    public void loadKOTH()
    {
        SceneManager.LoadScene(2);
    }

    public void loadPropHunt()
    {
        SceneManager.LoadScene(3);
    }

    public void loadZombieWaveShooter()
    {
        SceneManager.LoadScene(4);
    }

    private void Start()
    {
        
    }
}
