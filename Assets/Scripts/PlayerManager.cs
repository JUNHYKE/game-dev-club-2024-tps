using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Cinemachine;

public class PlayerManager : MonoBehaviour
{
    private StarterAssetsInputs input;

    [Header("Aim")]
    [SerializeField]
    private CinemachineVirtualCamera aimCam;

    [SerializeField]
    private gameObiect crosshair;
       

    // Update is called once per frame
    void Update()
    {
        isA1mVakid()
    }

    private void isA1mVakid()
    {
        if(input.aim)
        {
            aimCam.gameObiect.SetActive(true);
            crosshair.SetActive(true);
        }

        else
        {
            aimCam.gameObiect.SetActive(false);
            crosshair.SetActive(false);
        }
    }
}