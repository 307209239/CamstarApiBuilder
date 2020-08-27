// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RegulatoryAgencyChanges_Info
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
  public class RegulatoryAgencyChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_Info_RegulatoryReportMap")]
    protected RegulatoryReportMapChanges_Info _RegulatoryReportMap;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_Info_DecisionTreePageFlow")]
    protected Info _DecisionTreePageFlow;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public RegulatoryReportMapChanges_Info RegulatoryReportMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportMap), (object) value);
      }
      get
      {
        return (RegulatoryReportMapChanges_Info) this.PropertyGet(nameof (RegulatoryReportMap));
      }
    }

    public Info DecisionTreePageFlow
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTreePageFlow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecisionTreePageFlow));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
