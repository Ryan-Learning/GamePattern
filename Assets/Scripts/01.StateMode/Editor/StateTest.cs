using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class StateTest
{
    [Test]
    public void UnitTest()
    {
        Context theContext = new Context();
        theContext.SetState(new ConcreteStateA(theContext));

        theContext.Request(5);
        theContext.Request(15);
        theContext.Request(25);
        theContext.Request(35);
    }
}