using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestResetMultipleScript
{

    private GameObject[] testObject = new GameObject[5];
    private Vector3[] originalPositions = new Vector3[5];
    [SetUp]
    public void SetUp()
    {
        for (int i = 0; i < testObject.Length; i++)
        {
            testObject[i] = new GameObject("TestObject_" + i);
            testObject[i].transform.position = originalPositions[i] = Vector3.zero + new Vector3(i * 10, i * 10, i * 10);
            testObject[i].AddComponent<ResetPositions>();
        }
    }

    [Test]
    public void TestReset()
    {
        for (int i = 0; i < testObject.Length; i++)
        {
            testObject[i].transform.position = new Vector3(300 + i, 200 + i, 100 + i);
            var resetPositions = testObject[i].GetComponent<ResetPositions>();
            resetPositions.ResetPosition();
            Assert.AreEqual(originalPositions[i], testObject[i].transform.position);
        }
    }
}
