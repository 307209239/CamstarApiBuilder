// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RegulatoryAgencyChanges
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
  public class RegulatoryAgencyChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_RegulatoryReportMap")]
    protected RegulatoryReportMapChanges[] _RegulatoryReportMap;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_DecisionTreePageFlow")]
    protected NamedObjectRef _DecisionTreePageFlow;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryAgencyChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is RegulatoryAgencyChanges && object.Equals((object) this._ObjectToChange, (object) ((RegulatoryAgencyChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._RegulatoryReportMap, (Array) ((RegulatoryAgencyChanges) obj)._RegulatoryReportMap) && object.Equals((object) this._DecisionTreePageFlow, (object) ((RegulatoryAgencyChanges) obj)._DecisionTreePageFlow)) && object.Equals((object) this._Name, (object) ((RegulatoryAgencyChanges) obj)._Name) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public RegulatoryReportMapChanges[] RegulatoryReportMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportMap), (object) value);
      }
      get
      {
        return (RegulatoryReportMapChanges[]) this.PropertyGet(nameof (RegulatoryReportMap));
      }
    }

    public NamedObjectRef DecisionTreePageFlow
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTreePageFlow), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DecisionTreePageFlow));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
