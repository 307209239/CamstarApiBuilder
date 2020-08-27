// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleTestMaint_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class SampleTestMaint_Environment : RevisionedObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SampleTestMaint_Environment_BaseToChange")]
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTestBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    protected new Environment _BaseToChange;
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleTestMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTestBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleTestMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTestChanges", false, false, false, "SampleTestChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleTestMaint_Environment_ObjectChanges")]
    protected SampleTestChanges_Environment _ObjectChanges;

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public SampleTestChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SampleTestChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
