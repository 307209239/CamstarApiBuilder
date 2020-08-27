// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDistributeHistory
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
  public class ComponentDistributeHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_HistoryDetails")]
    protected IssueHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_BillControl")]
    protected Primitive<bool> _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_IssueControl")]
    protected Primitive<int> _IssueControl;

    public override bool Equals(object obj)
    {
      return obj is ComponentDistributeHistory && object.Equals((object) this._ExportImportKey, (object) ((ComponentDistributeHistory) obj)._ExportImportKey) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((ComponentDistributeHistory) obj)._HistoryDetails) && object.Equals((object) this._BillControl, (object) ((ComponentDistributeHistory) obj)._BillControl)) && (object.Equals((object) this._HistoryId, (object) ((ComponentDistributeHistory) obj)._HistoryId) && object.Equals((object) this._IssueControl, (object) ((ComponentDistributeHistory) obj)._IssueControl)) && base.Equals(obj);
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

    public IssueHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (IssueHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Primitive<bool> BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (BillControl));
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

    public Primitive<int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IssueControl));
      }
    }
  }
}
