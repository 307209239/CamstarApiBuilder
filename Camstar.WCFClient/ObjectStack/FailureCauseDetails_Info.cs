// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureCauseDetails_Info
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
  public class FailureCauseDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Info_Cause")]
    protected Info _Cause;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Info_FailurePlans")]
    protected FailurePlanDetails_Info _FailurePlans;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Info_FailureCauseData")]
    protected Info _FailureCauseData;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Info_RootCauseConfirmed")]
    protected Info _RootCauseConfirmed;

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

    public FailurePlanDetails_Info FailurePlans
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlans), (object) value);
      }
      get
      {
        return (FailurePlanDetails_Info) this.PropertyGet(nameof (FailurePlans));
      }
    }

    public Info FailureCauseData
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureCauseData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureCauseData));
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
