// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportController
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
  public class ExportImportController : ExportImportTxns
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportController_ExportImportType")]
    protected new Enumeration<ExportImportTypeEnum, int> _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportController_ExportImportFileURL")]
    protected Primitive<string> _ExportImportFileURL;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportController_ImportSetName")]
    protected Primitive<string> _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportController_DeleteExportContent")]
    protected Primitive<bool> _DeleteExportContent;

    public override bool Equals(object obj)
    {
      return obj is ExportImportController && object.Equals((object) this._ExportImportType, (object) ((ExportImportController) obj)._ExportImportType) && (object.Equals((object) this._ExportImportFileURL, (object) ((ExportImportController) obj)._ExportImportFileURL) && object.Equals((object) this._ImportSetName, (object) ((ExportImportController) obj)._ImportSetName)) && object.Equals((object) this._DeleteExportContent, (object) ((ExportImportController) obj)._DeleteExportContent) && base.Equals(obj);
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

    public Primitive<string> ExportImportFileURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportFileURL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportFileURL));
      }
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

    public Primitive<bool> DeleteExportContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteExportContent), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DeleteExportContent));
      }
    }
  }
}
