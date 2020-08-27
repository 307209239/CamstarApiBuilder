// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventCheckBoxFieldHistDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UserResponseYesNoFieldHistDet))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (OtherCheckBoxFieldHistDetail))]
  [Serializable]
  public class EventCheckBoxFieldHistDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventCheckBoxFieldHistDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventCheckBoxFieldHistDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is EventCheckBoxFieldHistDetail && object.Equals((object) this._ExportImportKey, (object) ((EventCheckBoxFieldHistDetail) obj)._ExportImportKey) && object.Equals((object) this._HistoryId, (object) ((EventCheckBoxFieldHistDetail) obj)._HistoryId) && base.Equals(obj);
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
