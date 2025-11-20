using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestOpenWebsiteScript
{
    private readonly GameObject testObject = new("TestObject");

    [SetUp]
    public void SetUp()
    {
        testObject.AddComponent<GoToWebsite>();
    }
    
    [Test]
    public void TestOpenWebsite()
    {
        var goToWebsiteComponent = testObject.GetComponent<GoToWebsite>();
        Assert.IsNotNull(goToWebsiteComponent);
    }
}
