﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionComponent : MonoBehaviour {
    Transform expressionParent;
    Transform panel;

    //NOTE: this script might be unnecessary, might just need ExpressionBody
	void Start () {
		
	}

    public void setExpressionParent(Transform p)
    {
        expressionParent = p;
    }

    public Transform getExpressionParent()
    {
        return expressionParent;
    }

    public void setPanel(Transform p)
    {
        panel = p;
    }

    public Transform getPanel()
    {
        return panel;
    }

    void Update() { }
}