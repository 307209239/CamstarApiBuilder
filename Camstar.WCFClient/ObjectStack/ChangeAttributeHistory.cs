// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeAttributeHistory
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
  public class ChangeAttributeHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistory_HistoryDetails")]
    protected ChangeAttributeHistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistory_IncludeChildren")]
    protected Primitive<int> _IncludeChildren;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ChangeAttributeHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ChangeAttributeHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((ChangeAttributeHistory) obj)._ExportImportKey) && object.Equals((object) this._IncludeChildren, (object) ((ChangeAttributeHistory) obj)._IncludeChildren)) && object.Equals((object) this._HistoryId, (object) ((ChangeAttributeHistory) obj)._HistoryId) && base.Equals(obj);
    }

    public ChangeAttributeHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ChangeAttributeHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
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

    public Primitive<int> IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IncludeChildren));
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
