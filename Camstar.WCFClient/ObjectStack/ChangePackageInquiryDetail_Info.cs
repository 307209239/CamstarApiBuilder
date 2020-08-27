// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageInquiryDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActivationInquiryDetail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PackageInquiryDetail_Info))]
  [Serializable]
  public class ChangePackageInquiryDetail_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Info_WorkflowStep")]
    protected Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Info_ChangePackage")]
    protected ChangePackage_Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Info_LastStateUpdateGMT")]
    protected Info _LastStateUpdateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Info_LastStateUpdate")]
    protected Info _LastStateUpdate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Info_RecommendedDeploymentDate")]
    protected Info _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Info_PackageName")]
    protected Info _PackageName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Info_Step")]
    protected Info _Step;

    public Info WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public ChangePackage_Info ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (ChangePackage_Info) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Info LastStateUpdateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStateUpdateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastStateUpdateGMT));
      }
    }

    public Info LastStateUpdate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStateUpdate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastStateUpdate));
      }
    }

    public Info RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageName));
      }
    }

    public Info Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Step));
      }
    }
  }
}
