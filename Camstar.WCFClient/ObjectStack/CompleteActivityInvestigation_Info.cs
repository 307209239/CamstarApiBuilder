// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityInvestigation_Info
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
  public class CompleteActivityInvestigation_Info : CompleteActivity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Info_ProcessObject")]
    protected new Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Info_Activity")]
    protected new Info _Activity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Info_Failures")]
    protected FailureDetails_Info _Failures;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Info_ProcessObjectDetails")]
    protected ActivityInvestigation_Info _ProcessObjectDetails;

    public new Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public new Info Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Activity));
      }
    }

    public FailureDetails_Info Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (FailureDetails_Info) this.PropertyGet(nameof (Failures));
      }
    }

    public ActivityInvestigation_Info ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ActivityInvestigation_Info) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }
  }
}
