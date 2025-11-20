using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestChangeMultipleModelTypesScript
{

    private readonly GameObject[] testObject = new GameObject[5];

    [SetUp]
    public void SetUp()
    {
        for (int i = 0; i < testObject.Length; i++)
        {
            testObject[i] = new GameObject("TestObject" + i);
            var arcadeModel = new GameObject("ArcadeModel" + i);
            var anatomicalModel = new GameObject("AnatomicalModel" + i);
            var ChangeModelTypeComponent = testObject[i].AddComponent<ChangeModelType>();
            ChangeModelTypeComponent.arcadeModel = arcadeModel;
            ChangeModelTypeComponent.anatomicalModel = anatomicalModel;
            arcadeModel.SetActive(true);
            anatomicalModel.SetActive(false);
        }
    }
    
    [Test]
    public void TestChangeModelTypeNotNull()
    {
        for (int i = 0; i < testObject.Length; i++)
        {
            var ChangeModelTypeComponent = testObject[i].GetComponent<ChangeModelType>();
            Assert.IsNotNull(ChangeModelTypeComponent);
        }
    }

    [Test]
    public void TestChangeSingleModelType()
    {
        for (int i = 0; i < testObject.Length; i++)
        {
            var ChangeModelTypeComponent = testObject[i].GetComponent<ChangeModelType>();
            var arcadeModel = ChangeModelTypeComponent.arcadeModel;
            var anatomicalModel = ChangeModelTypeComponent.anatomicalModel;
            ChangeModelTypeComponent.SwitchModels();
            Assert.IsFalse(arcadeModel.activeSelf);
            Assert.IsTrue(anatomicalModel.activeSelf);
        }
    }
}
