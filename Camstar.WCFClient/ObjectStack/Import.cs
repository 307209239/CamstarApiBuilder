// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Import
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
  public class Import : ExportImportTxns
  {
    [DataMember(EmitDefaultValue = false, Name = "Import_ExportImportType")]
    protected new Enumeration<ExportImportTypeEnum, int> _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "Import_ImportActionIfModified")]
    protected Enumeration<ImportActionEnum, int> _ImportActionIfModified;
    [DataMember(EmitDefaultValue = false, Name = "Import_ImportContents")]
    protected ImportContent[] _ImportContents;
    [DataMember(EmitDefaultValue = false, Name = "Import_ExportImportName")]
    protected new Primitive<string> _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "Import_ImportSetName")]
    protected Primitive<string> _ImportSetName;
    [DataMember(EmitDefaultValue = false, Name = "Import_ImportIfExists")]
    protected Primitive<bool> _ImportIfExists;
    [DataMember(EmitDefaultValue = false, Name = "Import_AutoBuildImportDetails")]
    protected Primitive<bool> _AutoBuildImportDetails;

    public override bool Equals(object obj)
    {
      return obj is Import && object.Equals((object) this._ExportImportType, (object) ((Import) obj)._ExportImportType) && (object.Equals((object) this._ImportActionIfModified, (object) ((Import) obj)._ImportActionIfModified) && this.CompareArrays((Array) this._ImportContents, (Array) ((Import) obj)._ImportContents)) && (object.Equals((object) this._ExportImportName, (object) ((Import) obj)._ExportImportName) && object.Equals((object) this._ImportSetName, (object) ((Import) obj)._ImportSetName) && (object.Equals((object) this._ImportIfExists, (object) ((Import) obj)._ImportIfExists) && object.Equals((object) this._AutoBuildImportDetails, (object) ((Import) obj)._AutoBuildImportDetails))) && base.Equals(obj);
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

    public Enumeration<ImportActionEnum, int> ImportActionIfModified
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportActionIfModified), (object) value);
      }
      get
      {
        return (Enumeration<ImportActionEnum, int>) this.PropertyGet(nameof (ImportActionIfModified));
      }
    }

    public ImportContent[] ImportContents
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportContents), (object) value);
      }
      get
      {
        return (ImportContent[]) this.PropertyGet(nameof (ImportContents));
      }
    }

    public new Primitive<string> ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportName));
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

    public Primitive<bool> ImportIfExists
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportIfExists), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ImportIfExists));
      }
    }

    public Primitive<bool> AutoBuildImportDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoBuildImportDetails), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoBuildImportDetails));
      }
    }
  }
}
