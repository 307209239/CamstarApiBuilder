// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataCollectionDefMaint_Environment
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
  public class DataCollectionDefMaint_Environment : RevisionedObjectMaint_Environment
  {
    [Metadata("An instance of a Data Collection Definition is used to provide revision control for referencing a Data Collection Definition CDO.", "DataCollectionDefChanges", false, false, false, "DataCollectionDefChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefMaint_Environment_ObjectChanges")]
    protected DataCollectionDefChanges_Environment _ObjectChanges;
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a ParametricData object, which is a list of data elements such as measurements that need to be recorded.", "DataCollectionDefBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefMaint_Environment_ObjectListInquiry")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a ParametricData object, which is a list of data elements such as measurements that need to be recorded.", "DataCollectionDefBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public DataCollectionDefChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DataCollectionDefChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

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
  }
}
