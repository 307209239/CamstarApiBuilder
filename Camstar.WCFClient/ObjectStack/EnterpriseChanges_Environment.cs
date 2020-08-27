// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EnterpriseChanges_Environment
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
  public class EnterpriseChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("A site is defined as an independent InSite entity within a manufacturing organization. While a factory is a physical facilities concept, a site is a self contained IT structure based on a single transaction processing database, along with the associated InSite servers that provide the capability to generate transactions in the database. A factory could have one or more sites; and a site could run one or more factories.", "Site", false, false, false, "NamedObjectRef", 1050974, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Environment_LiveConnectProxySite")]
    protected Environment _LiveConnectProxySite;
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Environment_TrainingReqGroup")]
    protected Environment _TrainingReqGroup;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050063, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("The Enterprise refers to the highest level in the factory definition. The Enterprise can represent the company itself, or a large division of the company. An Enterprise can contain one or more factories.", "Enterprise", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Environment_Factories")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048896, false, true, true, null)]
    protected Environment _Factories;
    [DataMember(EmitDefaultValue = false, Name = "EnterpriseChanges_Environment_ReportHeading")]
    [Metadata("Text for report headings", "", false, false, false, "String", 1048895, false, false, false, null)]
    protected Environment _ReportHeading;

    public Environment LiveConnectProxySite
    {
      [param: In] set
      {
        this.PropertySet(nameof (LiveConnectProxySite), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LiveConnectProxySite));
      }
    }

    public Environment TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingReqGroup));
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

    public Environment Factories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factories), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factories));
      }
    }

    public Environment ReportHeading
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportHeading), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportHeading));
      }
    }
  }
}
