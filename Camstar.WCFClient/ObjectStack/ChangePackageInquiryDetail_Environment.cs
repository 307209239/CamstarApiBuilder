// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageInquiryDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActivationInquiryDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PackageInquiryDetail_Environment))]
  [Serializable]
  public class ChangePackageInquiryDetail_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Environment_WorkflowStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "ChangeMgtSpecStep", false, false, true, "NamedSubentityRef", 1048855, false, false, false, null)]
    protected Environment _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Environment_ChangePackage")]
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, true, "ChangePackage", 1053240, false, false, false, null)]
    protected ChangePackage_Environment _ChangePackage;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16777346, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Environment_LastStateUpdateGMT")]
    protected Environment _LastStateUpdateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Environment_LastStateUpdate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16777344, false, false, false, null)]
    protected Environment _LastStateUpdate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778131, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Environment_RecommendedDeploymentDate")]
    protected Environment _RecommendedDeploymentDate;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Environment_PackageName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16777354, false, false, false, null)]
    protected Environment _PackageName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Environment_Step")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    protected Environment _Step;

    public Environment WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public ChangePackage_Environment ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (ChangePackage_Environment) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Environment LastStateUpdateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStateUpdateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastStateUpdateGMT));
      }
    }

    public Environment LastStateUpdate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStateUpdate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastStateUpdate));
      }
    }

    public Environment RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageName));
      }
    }

    public Environment Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Step));
      }
    }
  }
}
