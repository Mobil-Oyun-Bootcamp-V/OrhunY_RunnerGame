using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Animator CameraAnim;
    
    public enum States{UI, Level1, Level2, Level3}

    public static States _currentState;
    private int index;

    public void StartGame()
    {
        player.GetComponent<Animator>().SetTrigger("StartRun");
        StartCoroutine(CameraSwitch());
        index++;
        ChooseLevel(index);
    }

    public void ChooseLevel(int ind)
    {
        switch (ind)
        {
            case 0:
                _currentState = States.UI;
                break;
            case 1:
                _currentState = States.Level1;
                break;
            case 2:
                _currentState = States.Level2;
                break;
            case 3:
                _currentState = States.Level3;
                break;
        }
        StartGame();
    }

    IEnumerator CameraSwitch()
    {
        CameraAnim.Play("InGame");
        yield return new WaitForSeconds(2);
    }
}
