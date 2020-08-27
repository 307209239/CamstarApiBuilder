// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DefectHistory_Info
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
  public class DefectHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Info_Qty2Inspected")]
    protected Info _Qty2Inspected;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Info_HistoryDetails")]
    protected DefectHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Info_ContainersInspected")]
    protected Info _ContainersInspected;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Info_ContainerLevelInspected")]
    protected Info _ContainerLevelInspected;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Info_QtyInspected")]
    protected Info _QtyInspected;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistory_Info_ChargeToStep")]
    protected Info _ChargeToStep;

    public Info Qty2Inspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Inspected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Inspected));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public DefectHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DefectHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info ContainersInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainersInspected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainersInspected));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info ContainerLevelInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelInspected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerLevelInspected));
      }
    }

    public Info QtyInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyInspected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyInspected));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChargeToStep));
      }
    }
  }
}
