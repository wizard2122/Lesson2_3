using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    public event Action<int> Changed;

    public int Value { get; private set; }

    public void Add()
    {
        Value++;
        Changed?.Invoke(Value);
    }
}
