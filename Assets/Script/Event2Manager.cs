﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event2Manager : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    

    public void canExitChange() {

        gameObject.layer = 0;
    }
}
