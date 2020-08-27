// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureDataHistoryDetails_Info
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
  public class FailureDataHistoryDetails_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Info_FailureType")]
    protected Info _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Info_FailureSeverity")]
    protected Info _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Info_FailureMode")]
    protected Info _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Info_CauseHistoryDetails")]
    protected FailureCauseDataHistoryDetails_Info _CauseHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Info_Description")]
    protected Info _Description;

    public Info FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureType));
      }
    }

    public Info FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public Info FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureMode));
      }
    }

    public FailureCauseDataHistoryDetails_Info CauseHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseHistoryDetails), (object) value);
      }
      get
      {
        return (FailureCauseDataHistoryDetails_Info) this.PropertyGet(nameof (CauseHistoryDetails));
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
  }
}
