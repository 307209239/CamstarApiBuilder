// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleDataPointMaint_Environment
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
  public class SampleDataPointMaint_Environment : RevisionedObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointMaint_Environment_BaseToChange")]
    [Metadata("Object used for defining a reusable data points.", "SampleDataPointBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointMaint_Environment_ObjectListInquiry")]
    [Metadata("Object used for defining a reusable data points.", "SampleDataPointBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Object used for defining a reusable data points.", "SampleDataPoint", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointMaint_Environment_ObjectChanges")]
    [Metadata("Object used for defining a reusable data points.", "SampleDataPointChanges", false, false, false, "SampleDataPointChanges", 1048873, true, false, false, null)]
    protected SampleDataPointChanges_Environment _ObjectChanges;

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

    public SampleDataPointChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SampleDataPointChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
