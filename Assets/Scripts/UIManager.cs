﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public GameObject canvas;
    public GameObject piece_buttons;

    enum CONTROL_BUTTONS { DEPLOY = 0, RUN, PAUSE};
    // Start is called before the first frame update
    void Start()
    {
        //canvas.transform.GetChild((int)CONTROL_BUTTONS.RUN).gameObject.SetActive(false);
       // canvas.transform.GetChild((int)CONTROL_BUTTONS.PAUSE).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPieceButtonClick(int type)
    {
        PieceManager.Instance.piece_spawner.SetSpawnerType((Piece.PieceType)type);
    }

    internal void OnRun()
    {
        piece_buttons.SetActive(false);
    }

    internal void OnDeployment()
    {
        piece_buttons.SetActive(true);
    }
}
