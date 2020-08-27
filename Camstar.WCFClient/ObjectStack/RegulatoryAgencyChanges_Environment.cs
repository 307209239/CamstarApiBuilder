// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RegulatoryAgencyChanges_Environment
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
  public class RegulatoryAgencyChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_Environment_ObjectToChange")]
    [Metadata("Regulatory Agency", "RegulatoryAgency", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_Environment_RegulatoryReportMap")]
    [Metadata("Regulatory Report Map", "RegulatoryReportMapChanges", false, false, false, "RegulatoryReportMapChanges", 1051717, false, true, false, null)]
    protected RegulatoryReportMapChanges_Environment _RegulatoryReportMap;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_Environment_DecisionTreePageFlow")]
    [Metadata("PageFlow component for the UI Personalization Persistence Provider.", "UIPageFlow", false, true, false, "NamedObjectRef", 1051719, false, false, true, null)]
    protected Environment _DecisionTreePageFlow;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051718, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_Environment_Name")]
    protected new Environment _Name;

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

    public RegulatoryReportMapChanges_Environment RegulatoryReportMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportMap), (object) value);
      }
      get
      {
        return (RegulatoryReportMapChanges_Environment) this.PropertyGet(nameof (RegulatoryReportMap));
      }
    }

    public Environment DecisionTreePageFlow
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTreePageFlow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecisionTreePageFlow));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
