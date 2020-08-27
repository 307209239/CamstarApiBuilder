// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionDefMaint_Environment
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
  public class DataPointCollectionDefMaint_Environment : DataCollectionDefMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefMaint_Environment_ObjectChanges")]
    [Metadata("A data collection that can be processed from any Shopfloor service.", "DataPointCollectionDefChanges", false, false, false, "DataPointCollectionDefChanges", 1048873, true, false, false, null)]
    protected DataPointCollectionDefChanges_Environment _ObjectChanges;
    [Metadata("A data collection that can be processed from any Shopfloor service.", "DataPointCollectionDefBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefMaint_Environment_BaseToChange")]
    [Metadata("A data collection that can be processed from any Shopfloor service.", "DataPointCollectionDefBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefMaint_Environment_ObjectToChange")]
    [Metadata("A data collection that can be processed from any Shopfloor service.", "DataPointCollectionDef", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public DataPointCollectionDefChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DataPointCollectionDefChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
