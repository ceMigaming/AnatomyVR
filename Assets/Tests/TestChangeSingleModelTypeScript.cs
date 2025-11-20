using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestChangeSingleModelTypeScript
{

    private readonly GameObject testObject = new("TestObject");
    private readonly GameObject arcadeModel = new("ArcadeModel");
    private readonly GameObject anatomicalModel = new("AnatomicalModel");

    [SetUp]
    public void SetUp()
    {
        var ChangeModelTypeComponent = testObject.AddComponent<ChangeModelType>();
        ChangeModelTypeComponent.arcadeModel = arcadeModel;
        ChangeModelTypeComponent.anatomicalModel = anatomicalModel;
        arcadeModel.SetActive(true);
        anatomicalModel.SetActive(false);
    }
    
    [Test]
    public void TestChangeModelTypeNotNull()
    {
        var ChangeModelTypeComponent = testObject.GetComponent<ChangeModelType>();
        Assert.IsNotNull(ChangeModelTypeComponent);
    }

    [Test]
    public void TestChangeSingleModelType()
    {
        var ChangeModelTypeComponent = testObject.GetComponent<ChangeModelType>();
        ChangeModelTypeComponent.SwitchModels();
        Assert.IsFalse(arcadeModel.activeSelf);
        Assert.IsTrue(anatomicalModel.activeSelf);
    }
}
