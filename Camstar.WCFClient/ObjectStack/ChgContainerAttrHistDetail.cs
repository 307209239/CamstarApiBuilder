// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerAttrHistDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContainerMaintHistDetail))]
  [Serializable]
  public class ChgContainerAttrHistDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistDetail_IsPreHistory")]
    protected Primitive<bool> _IsPreHistory;

    public override bool Equals(object obj)
    {
      return obj is ChgContainerAttrHistDetail && object.Equals((object) this._ExportImportKey, (object) ((ChgContainerAttrHistDetail) obj)._ExportImportKey) && (object.Equals((object) this._HistoryId, (object) ((ChgContainerAttrHistDetail) obj)._HistoryId) && object.Equals((object) this._IsPreHistory, (object) ((ChgContainerAttrHistDetail) obj)._IsPreHistory)) && base.Equals(obj);
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

    public Primitive<bool> IsPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPreHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsPreHistory));
      }
    }
  }
}
