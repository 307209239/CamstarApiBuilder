// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ImportStatusInquiry_Environment
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
  public class ImportStatusInquiry_Environment : ExportImportInquiry_Environment
  {
    [Metadata("ExportImportName", "", false, true, false, "String", 1050828, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ImportStatusInquiry_Environment_ImportSetName")]
    protected Environment _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "ImportStatusInquiry_Environment_ImportSetStatus")]
    [Metadata("ExportImportStatusType", "ExportImportStatusEnum", false, false, true, "Integer", 1050842, false, false, false, null)]
    protected Environment _ImportSetStatus;
    [DataMember(EmitDefaultValue = false, Name = "ImportStatusInquiry_Environment_ExportImportType")]
    [Metadata("ExportImportType", "ExportImportTypeEnum", false, false, true, "Integer", 1050832, false, false, false, null)]
    protected new Environment _ExportImportType;

    public Environment ImportSetName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImportSetName));
      }
    }

    public Environment ImportSetStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSetStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImportSetStatus));
      }
    }

    public new Environment ExportImportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportType));
      }
    }
  }
}
