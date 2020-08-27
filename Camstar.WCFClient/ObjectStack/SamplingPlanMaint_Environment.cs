// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingPlanMaint_Environment
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
  public class SamplingPlanMaint_Environment : RevisionedObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanMaint_Environment_BaseToChange")]
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlanBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    protected new Environment _BaseToChange;
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanMaint_Environment_ObjectListInquiry")]
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlanBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanMaint_Environment_ObjectChanges")]
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlanChanges", false, false, false, "SamplingPlanChanges", 1048873, true, false, false, null)]
    protected SamplingPlanChanges_Environment _ObjectChanges;

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
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

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public SamplingPlanChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SamplingPlanChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
