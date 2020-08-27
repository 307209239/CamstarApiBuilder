// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageInquiryDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActivationInquiryDetail))]
  [KnownType(typeof (PackageInquiryDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChangePackageInquiryDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_ChangePackage")]
    protected ChangePackage _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_LastStateUpdateGMT")]
    protected Primitive<DateTime> _LastStateUpdateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_LastStateUpdate")]
    protected Primitive<DateTime> _LastStateUpdate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_RecommendedDeploymentDate")]
    protected Primitive<DateTime> _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_PackageName")]
    protected Primitive<string> _PackageName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiryDetail_Step")]
    protected Primitive<string> _Step;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageInquiryDetail && object.Equals((object) this._WorkflowStep, (object) ((ChangePackageInquiryDetail) obj)._WorkflowStep) && (object.Equals((object) this._ChangePackage, (object) ((ChangePackageInquiryDetail) obj)._ChangePackage) && object.Equals((object) this._LastStateUpdateGMT, (object) ((ChangePackageInquiryDetail) obj)._LastStateUpdateGMT)) && (object.Equals((object) this._LastStateUpdate, (object) ((ChangePackageInquiryDetail) obj)._LastStateUpdate) && object.Equals((object) this._RecommendedDeploymentDate, (object) ((ChangePackageInquiryDetail) obj)._RecommendedDeploymentDate) && (object.Equals((object) this._Description, (object) ((ChangePackageInquiryDetail) obj)._Description) && object.Equals((object) this._PackageName, (object) ((ChangePackageInquiryDetail) obj)._PackageName))) && object.Equals((object) this._Step, (object) ((ChangePackageInquiryDetail) obj)._Step) && base.Equals(obj);
    }

    public NamedSubentityRef WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public ChangePackage ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (ChangePackage) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Primitive<DateTime> LastStateUpdateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStateUpdateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastStateUpdateGMT));
      }
    }

    public Primitive<DateTime> LastStateUpdate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStateUpdate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastStateUpdate));
      }
    }

    public Primitive<DateTime> RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<string> PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageName));
      }
    }

    public Primitive<string> Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Step));
      }
    }
  }
}
