// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportInquiry_Environment
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
  public class ExportImportInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Environment_ExportImportName")]
    [Metadata("ExportImportName", "", false, true, false, "String", 1050821, false, false, true, null)]
    protected Environment _ExportImportName;
    [Metadata("Export Import Status", "ExportImportStatus", false, false, true, "ExportImportStatus", 1050837, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Environment_StatusDetails")]
    protected ExportImportStatus_Environment _StatusDetails;
    [Metadata("ExportImportType", "ExportImportTypeEnum", false, false, true, "Integer", 1050832, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Environment_ExportImportType")]
    protected Environment _ExportImportType;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053091, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Environment_LogStartRow")]
    protected Environment _LogStartRow;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050841, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Environment_IncludeLog")]
    protected Environment _IncludeLog;

    public Environment ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public ExportImportStatus_Environment StatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusDetails), (object) value);
      }
      get
      {
        return (ExportImportStatus_Environment) this.PropertyGet(nameof (StatusDetails));
      }
    }

    public Environment ExportImportType
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

    public Environment LogStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (LogStartRow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LogStartRow));
      }
    }

    public Environment IncludeLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeLog), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeLog));
      }
    }
  }
}
