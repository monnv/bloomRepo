﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic

public class GameManager : MonoBehaviour
{

    public Questions[] questions;
    private static List<Questions> unansweredQuestions;

    private void Start()
    {
        if (unansweredQuestions == null)
        {
            unansweredQuestions = questions;
        }


    }

}
