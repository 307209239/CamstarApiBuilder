// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Export_Info
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
  public class Export_Info : ExportImportTxns_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Export_Info_ExportImportType")]
    protected new Info _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "Export_Info_ExportImportName")]
    protected new Info _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "Export_Info_ExportLocationURL")]
    protected Info _ExportLocationURL;
    [DataMember(EmitDefaultValue = false, Name = "Export_Info_TargetSystems")]
    protected Info _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "Export_Info_TrackableObjectCDOTypeId")]
    protected Info _TrackableObjectCDOTypeId;
    [DataMember(EmitDefaultValue = false, Name = "Export_Info_GenerateExportFile")]
    protected Info _GenerateExportFile;
    [DataMember(EmitDefaultValue = false, Name = "Export_Info_TrackableObject")]
    protected Info _TrackableObject;

    public new Info ExportImportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportType));
      }
    }

    public new Info ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public Info ExportLocationURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportLocationURL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportLocationURL));
      }
    }

    public Info TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public Info TrackableObjectCDOTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObjectCDOTypeId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObjectCDOTypeId));
      }
    }

    public Info GenerateExportFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (GenerateExportFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GenerateExportFile));
      }
    }

    public Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }
  }
}
