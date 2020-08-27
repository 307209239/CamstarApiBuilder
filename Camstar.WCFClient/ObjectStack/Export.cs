// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Export
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
  public class Export : ExportImportTxns
  {
    [DataMember(EmitDefaultValue = false, Name = "Export_ExportImportType")]
    protected new Enumeration<ExportImportTypeEnum, int> _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "Export_ExportImportName")]
    protected new Primitive<string> _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "Export_ExportLocationURL")]
    protected Primitive<string> _ExportLocationURL;
    [DataMember(EmitDefaultValue = false, Name = "Export_TargetSystems")]
    protected NamedObjectRef[] _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "Export_TrackableObjectCDOTypeId")]
    protected Primitive<int> _TrackableObjectCDOTypeId;
    [DataMember(EmitDefaultValue = false, Name = "Export_GenerateExportFile")]
    protected Primitive<bool> _GenerateExportFile;
    [DataMember(EmitDefaultValue = false, Name = "Export_TrackableObject")]
    protected BaseObjectRef _TrackableObject;

    public override bool Equals(object obj)
    {
      return obj is Export && object.Equals((object) this._ExportImportType, (object) ((Export) obj)._ExportImportType) && (object.Equals((object) this._ExportImportName, (object) ((Export) obj)._ExportImportName) && object.Equals((object) this._ExportLocationURL, (object) ((Export) obj)._ExportLocationURL)) && (this.CompareArrays((Array) this._TargetSystems, (Array) ((Export) obj)._TargetSystems) && object.Equals((object) this._TrackableObjectCDOTypeId, (object) ((Export) obj)._TrackableObjectCDOTypeId) && (object.Equals((object) this._GenerateExportFile, (object) ((Export) obj)._GenerateExportFile) && object.Equals((object) this._TrackableObject, (object) ((Export) obj)._TrackableObject))) && base.Equals(obj);
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

    public Primitive<string> ExportLocationURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportLocationURL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportLocationURL));
      }
    }

    public NamedObjectRef[] TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public Primitive<int> TrackableObjectCDOTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObjectCDOTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TrackableObjectCDOTypeId));
      }
    }

    public Primitive<bool> GenerateExportFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (GenerateExportFile), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (GenerateExportFile));
      }
    }

    public BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }
  }
}
