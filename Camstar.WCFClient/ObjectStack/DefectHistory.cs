// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DefectHistory
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
  public class DefectHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Qty2Inspected")]
    protected Primitive<double> _Qty2Inspected;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_HistoryDetails")]
    protected DefectHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_ContainersInspected")]
    protected Primitive<int> _ContainersInspected;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_ContainerLevelInspected")]
    protected NamedObjectRef _ContainerLevelInspected;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_QtyInspected")]
    protected Primitive<double> _QtyInspected;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;

    public override bool Equals(object obj)
    {
      return obj is DefectHistory && object.Equals((object) this._Qty2Inspected, (object) ((DefectHistory) obj)._Qty2Inspected) && (object.Equals((object) this._ExportImportKey, (object) ((DefectHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((DefectHistory) obj)._HistoryDetails)) && (object.Equals((object) this._ContainersInspected, (object) ((DefectHistory) obj)._ContainersInspected) && object.Equals((object) this._HistoryId, (object) ((DefectHistory) obj)._HistoryId) && (object.Equals((object) this._ContainerLevelInspected, (object) ((DefectHistory) obj)._ContainerLevelInspected) && object.Equals((object) this._QtyInspected, (object) ((DefectHistory) obj)._QtyInspected))) && (object.Equals((object) this._Resource, (object) ((DefectHistory) obj)._Resource) && object.Equals((object) this._ChargeToStep, (object) ((DefectHistory) obj)._ChargeToStep)) && base.Equals(obj);
    }

    public Primitive<double> Qty2Inspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Inspected), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Inspected));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public DefectHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DefectHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Primitive<int> ContainersInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainersInspected), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ContainersInspected));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public NamedObjectRef ContainerLevelInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelInspected), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerLevelInspected));
      }
    }

    public Primitive<double> QtyInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyInspected), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyInspected));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public NamedSubentityRef ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ChargeToStep));
      }
    }
  }
}
