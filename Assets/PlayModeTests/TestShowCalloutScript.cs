using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestShowCalloutScript
{

    private GameObject testObject;

    [SetUp]
    public void SetUp()
    {
        testObject = new GameObject("TestObject");
        var showCalloutOnActivate = testObject.AddComponent<ShowCalloutOnActivate>();
        showCalloutOnActivate.callout = new GameObject("Callout");
        showCalloutOnActivate.callout.SetActive(false);
    }

    [Test]
    public void TestShowCallout()
    {
        var showCalloutOnActivate = testObject.GetComponent<ShowCalloutOnActivate>();
        showCalloutOnActivate.OnActivated(null);
        Assert.True(showCalloutOnActivate.callout.activeSelf);
    }
}
