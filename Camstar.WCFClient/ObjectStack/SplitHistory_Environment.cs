// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SplitHistory_Environment
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
  public class SplitHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("History Detail object for the Split Service.  One SplitHistory object will be created for every split.  The SplitHistory object will contain all the history information needed for the Split service that is not already contained in the HistoryMainline object.", "SplitHistoryDetails", false, false, false, "SplitHistoryDetails", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Environment_HistoryDetails")]
    protected SplitHistoryDetails_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Environment_Qty2")]
    protected Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Environment_UnitCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048852, false, false, false, null)]
    protected Environment _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Environment_ChildCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048770, false, false, false, null)]
    protected Environment _ChildCount;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049397, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Environment_FromContainer")]
    protected Environment _FromContainer;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049398, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Environment_Closed")]
    protected Environment _Closed;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Environment_Qty")]
    protected Environment _Qty;

    public SplitHistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (SplitHistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
      }
    }

    public Environment UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Environment ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Environment FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromContainer));
      }
    }

    public Environment Closed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Closed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Closed));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
