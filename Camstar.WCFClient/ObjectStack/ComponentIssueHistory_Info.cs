// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssueHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (BatchDispenseHistory_Info))]
  [KnownType(typeof (RecipeDispenseHistory_Info))]
  [Serializable]
  public class ComponentIssueHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_Info_HistoryDetails")]
    protected IssueHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_Info_BillControl")]
    protected Info _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_Info_HistoryId")]
    protected new Info _HistoryId;

    public IssueHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (IssueHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BillControl));
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
  }
}
