// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RegulatoryReportMapChanges_Environment
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
  public class RegulatoryReportMapChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_Environment_ObjectToChange")]
    [Metadata("Regulatory Report Map", "RegulatoryReportMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_Environment_ListItemToChange")]
    [Metadata("Regulatory Report Map", "RegulatoryReportMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_Environment_RegulatoryReportType")]
    [Metadata("Regulatory Report Type", "RegulatoryReportType", false, false, false, "NamedObjectRef", 1051722, false, false, true, null)]
    protected Environment _RegulatoryReportType;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_Environment_ReportMappingConfig")]
    [Metadata("Report Mapping Config", "ReportMappingConfig", false, false, false, "NamedObjectRef", 1051720, false, false, true, null)]
    protected Environment _ReportMappingConfig;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1051721, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_Environment_SubmissionPeriod")]
    protected Environment _SubmissionPeriod;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportMapChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment RegulatoryReportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RegulatoryReportType));
      }
    }

    public Environment ReportMappingConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportMappingConfig), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportMappingConfig));
      }
    }

    public Environment SubmissionPeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionPeriod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubmissionPeriod));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
