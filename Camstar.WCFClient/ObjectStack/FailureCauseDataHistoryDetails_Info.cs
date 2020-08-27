// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureCauseDataHistoryDetails_Info
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
  public class FailureCauseDataHistoryDetails_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Info_Cause")]
    protected Info _Cause;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Info_FailurePlanHistoryDetails")]
    protected FailurePlanDataHistoryDetails_Info _FailurePlanHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Info_RootCauseConfirmed")]
    protected Info _RootCauseConfirmed;

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info Cause
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cause), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Cause));
      }
    }

    public FailurePlanDataHistoryDetails_Info FailurePlanHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlanHistoryDetails), (object) value);
      }
      get
      {
        return (FailurePlanDataHistoryDetails_Info) this.PropertyGet(nameof (FailurePlanHistoryDetails));
      }
    }

    public Info RootCauseConfirmed
    {
      [param: In] set
      {
        this.PropertySet(nameof (RootCauseConfirmed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RootCauseConfirmed));
      }
    }
  }
}
