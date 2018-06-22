using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {

    
<<<<<<< HEAD
    /*public void PlayGame()
=======
    public void PlayGame()
>>>>>>> 1e9e935fa4093bda12d7918134fef7c368694bfe
    {
        SceneManager.LoadScene(2);
    }
    */
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Below here are track selection buttons

    public void Track01()
    {
        SceneManager.LoadScene(2);
    }

    public void Track02()
    {
        SceneManager.LoadScene(3);
    }

    public void Track03()
    {
        SceneManager.LoadScene(4);
    }

    public void Track04()
    {
        SceneManager.LoadScene(5);
    }

    public void Track05()
    {
        SceneManager.LoadScene(6);
    }

<<<<<<< HEAD
    public void Credits()
    {
        SceneManager.LoadScene(7);
    }

=======
>>>>>>> 1e9e935fa4093bda12d7918134fef7c368694bfe
}
