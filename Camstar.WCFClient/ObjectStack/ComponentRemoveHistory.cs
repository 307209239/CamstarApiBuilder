// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentRemoveHistory
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
  public class ComponentRemoveHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemoveHistory_HistoryDetails")]
    protected RemovalHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemoveHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentRemoveHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ComponentRemoveHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ComponentRemoveHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((ComponentRemoveHistory) obj)._ExportImportKey) && object.Equals((object) this._HistoryId, (object) ((ComponentRemoveHistory) obj)._HistoryId)) && base.Equals(obj);
    }

    public RemovalHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (RemovalHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
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
  }
}
