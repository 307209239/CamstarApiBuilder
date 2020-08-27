// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ImportStatusInquiry
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
  public class ImportStatusInquiry : ExportImportInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ImportStatusInquiry_ImportSetName")]
    protected Primitive<string> _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "ImportStatusInquiry_ImportSetStatus")]
    protected Enumeration<ExportImportStatusEnum, int> _ImportSetStatus;
    [DataMember(EmitDefaultValue = false, Name = "ImportStatusInquiry_ExportImportType")]
    protected new Enumeration<ExportImportTypeEnum, int> _ExportImportType;

    public override bool Equals(object obj)
    {
      return obj is ImportStatusInquiry && object.Equals((object) this._ImportSetName, (object) ((ImportStatusInquiry) obj)._ImportSetName) && (object.Equals((object) this._ImportSetStatus, (object) ((ImportStatusInquiry) obj)._ImportSetStatus) && object.Equals((object) this._ExportImportType, (object) ((ImportStatusInquiry) obj)._ExportImportType)) && base.Equals(obj);
    }

    public Primitive<string> ImportSetName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ImportSetName));
      }
    }

    public Enumeration<ExportImportStatusEnum, int> ImportSetStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetStatus), (object) value);
      }
      get
      {
        return (Enumeration<ExportImportStatusEnum, int>) this.PropertyGet(nameof (ImportSetStatus));
      }
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
