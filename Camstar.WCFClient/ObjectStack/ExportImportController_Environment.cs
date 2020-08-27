// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportController_Environment
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
  public class ExportImportController_Environment : ExportImportTxns_Environment
  {
    [Metadata("ExportImportType", "ExportImportTypeEnum", false, true, false, "Integer", 1050845, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportController_Environment_ExportImportType")]
    protected new Environment _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportController_Environment_ExportImportFileURL")]
    [Metadata("URL", "", false, false, false, "String", 1050831, false, false, false, null)]
    protected Environment _ExportImportFileURL;
    [Metadata("ExportImportName", "", false, false, false, "String", 1050861, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportController_Environment_ImportSetName")]
    protected Environment _ImportSetName;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050865, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportController_Environment_DeleteExportContent")]
    protected Environment _DeleteExportContent;

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

    public Environment ExportImportFileURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportFileURL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportFileURL));
      }
    }

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

    public Environment DeleteExportContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteExportContent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeleteExportContent));
      }
    }
  }
}
