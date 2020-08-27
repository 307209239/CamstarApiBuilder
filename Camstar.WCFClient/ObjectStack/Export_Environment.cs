// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Export_Environment
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
  public class Export_Environment : ExportImportTxns_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Export_Environment_ExportImportType")]
    [Metadata("ExportImportType", "ExportImportTypeEnum", false, false, true, "Integer", 1050845, false, false, false, null)]
    protected new Environment _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "Export_Environment_ExportImportName")]
    [Metadata("ExportImportName", "", false, true, false, "String", 1050821, false, false, false, null)]
    protected new Environment _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "Export_Environment_ExportLocationURL")]
    [Metadata("URL", "", false, true, false, "String", 1050825, false, false, false, null)]
    protected Environment _ExportLocationURL;
    [DataMember(EmitDefaultValue = false, Name = "Export_Environment_TargetSystems")]
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, false, "NamedObjectRef", 1053270, false, true, false, null)]
    protected Environment _TargetSystems;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 16777357, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Export_Environment_TrackableObjectCDOTypeId")]
    protected Environment _TrackableObjectCDOTypeId;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050826, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Export_Environment_GenerateExportFile")]
    protected Environment _GenerateExportFile;
    [DataMember(EmitDefaultValue = false, Name = "Export_Environment_TrackableObject")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051446, false, false, false, null)]
    protected Environment _TrackableObject;

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

    public new Environment ExportImportName
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

    public Environment ExportLocationURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportLocationURL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportLocationURL));
      }
    }

    public Environment TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public Environment TrackableObjectCDOTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObjectCDOTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObjectCDOTypeId));
      }
    }

    public Environment GenerateExportFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (GenerateExportFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GenerateExportFile));
      }
    }

    public Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }
  }
}
