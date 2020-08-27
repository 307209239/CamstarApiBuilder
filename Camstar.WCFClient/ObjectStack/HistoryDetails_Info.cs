// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BusinessRuleParameterValues_Info))]
  [KnownType(typeof (ServiceHistoryDetail_Info))]
  [KnownType(typeof (StartHistoryDetail_Info))]
  [KnownType(typeof (AuditTrailHeader_Info))]
  [KnownType(typeof (BusinessRuleExecutionHistory_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ServiceHistorySummary_Info))]
  [KnownType(typeof (AuditTrail_Info))]
  [KnownType(typeof (ParametricDetail_Info))]
  [Serializable]
  public class HistoryDetails_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryDetails_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "HistoryDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HistoryDetails_Info_HistoryId")]
    protected Info _HistoryId;

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
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

    public Info HistoryId
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
  }
}
