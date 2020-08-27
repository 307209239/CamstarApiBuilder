// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RegulatoryReportMapChanges
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
  public class RegulatoryReportMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_RegulatoryReportType")]
    protected NamedObjectRef _RegulatoryReportType;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_ReportMappingConfig")]
    protected NamedObjectRef _ReportMappingConfig;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_SubmissionPeriod")]
    protected Primitive<int> _SubmissionPeriod;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is RegulatoryReportMapChanges && object.Equals((object) this._ObjectToChange, (object) ((RegulatoryReportMapChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((RegulatoryReportMapChanges) obj)._ListItemToChange) && object.Equals((object) this._RegulatoryReportType, (object) ((RegulatoryReportMapChanges) obj)._RegulatoryReportType)) && (object.Equals((object) this._ReportMappingConfig, (object) ((RegulatoryReportMapChanges) obj)._ReportMappingConfig) && object.Equals((object) this._SubmissionPeriod, (object) ((RegulatoryReportMapChanges) obj)._SubmissionPeriod) && object.Equals((object) this._IsFrozen, (object) ((RegulatoryReportMapChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedObjectRef RegulatoryReportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RegulatoryReportType));
      }
    }

    public NamedObjectRef ReportMappingConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportMappingConfig), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReportMappingConfig));
      }
    }

    public Primitive<int> SubmissionPeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionPeriod), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SubmissionPeriod));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
