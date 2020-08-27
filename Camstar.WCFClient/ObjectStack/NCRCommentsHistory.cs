// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCommentsHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (NCRPreventiveActionHistory))]
  [KnownType(typeof (NCRCorrectiveActionHistory))]
  [KnownType(typeof (NCRFailureInvestigationHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class NCRCommentsHistory : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCommentsHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCRCommentsHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCRCommentsHistory_Comments")]
    protected Primitive<string> _Comments;

    public override bool Equals(object obj)
    {
      return obj is NCRCommentsHistory && object.Equals((object) this._ExportImportKey, (object) ((NCRCommentsHistory) obj)._ExportImportKey) && (object.Equals((object) this._HistoryId, (object) ((NCRCommentsHistory) obj)._HistoryId) && object.Equals((object) this._Comments, (object) ((NCRCommentsHistory) obj)._Comments)) && base.Equals(obj);
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

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
