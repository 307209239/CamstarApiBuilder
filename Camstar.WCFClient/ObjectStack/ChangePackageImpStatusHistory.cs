// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageImpStatusHistory
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
  public class ChangePackageImpStatusHistory : ChangePackageStatusHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageImpStatusHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageImpStatusHistory_ToStatus")]
    protected Enumeration<ChangePackageImportStatusEnum, int> _ToStatus;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageImpStatusHistory && object.Equals((object) this._ExportImportKey, (object) ((ChangePackageImpStatusHistory) obj)._ExportImportKey) && object.Equals((object) this._ToStatus, (object) ((ChangePackageImpStatusHistory) obj)._ToStatus) && base.Equals(obj);
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

    public Enumeration<ChangePackageImportStatusEnum, int> ToStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStatus), (object) value);
      }
      get
      {
        return (Enumeration<ChangePackageImportStatusEnum, int>) this.PropertyGet(nameof (ToStatus));
      }
    }
  }
}
