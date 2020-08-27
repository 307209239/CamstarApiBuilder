// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCrossRefHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ResolveCARRefHistory_Environment))]
  [Serializable]
  public class QualityCrossRefHistory_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Environment_TrackingId")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051484, false, false, false, null)]
    protected Environment _TrackingId;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Environment_CrossReference")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051488, false, false, false, null)]
    protected Environment _CrossReference;
    [Metadata("Identifies the valid resolution codes for closing an Event or CAPA.", "QualityResolutionCode", false, false, true, "NamedObjectRef", 1051418, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Environment_QualityResolutionCode")]
    protected Environment _QualityResolutionCode;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051526, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Environment_CloseReference")]
    protected Environment _CloseReference;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Environment_ExecuteAction")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1051489, false, false, false, null)]
    protected Environment _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityCrossRefHistory_Environment_CloseDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1051417, false, false, false, null)]
    protected Environment _CloseDescription;

    public Environment TrackingId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackingId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackingId));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment CrossReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossReference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CrossReference));
      }
    }

    public Environment QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Environment CloseReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseReference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseReference));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public Environment CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseDescription));
      }
    }
  }
}
