using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestResetSingleScript
{

    private GameObject testObject;

    [SetUp]
    public void SetUp()
    {
        testObject = new GameObject("TestObject");
        testObject.transform.position = Vector3.zero;
        testObject.AddComponent<ResetPositions>();
    }

    [Test]
    public void TestReset()
    {
        testObject.transform.position = new Vector3(300, 200, 100);
        var resetPositions = testObject.GetComponent<ResetPositions>();
        resetPositions.ResetPosition();
        Assert.AreEqual(Vector3.zero, testObject.transform.position);
    }
}
