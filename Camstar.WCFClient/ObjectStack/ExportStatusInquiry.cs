// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportStatusInquiry
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
  public class ExportStatusInquiry : ExportImportInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportStatusInquiry_ExportImportType")]
    protected new Enumeration<ExportImportTypeEnum, int> _ExportImportType;

    public override bool Equals(object obj)
    {
      return obj is ExportStatusInquiry && object.Equals((object) this._ExportImportType, (object) ((ExportStatusInquiry) obj)._ExportImportType) && base.Equals(obj);
    }

    public new Enumeration<ExportImportTypeEnum, int> ExportImportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportType), (object) value);
      }
      get
      {
        return (Enumeration<ExportImportTypeEnum, int>) this.PropertyGet(nameof (ExportImportType));
      }
    }
  }
}
