// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureDetails_Info
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
  public class FailureDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Info_FailureType")]
    protected Info _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Info_FailureMode")]
    protected Info _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Info_FailureSeverity")]
    protected Info _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Info_Causes")]
    protected FailureCauseDetails_Info _Causes;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Info_FailureData")]
    protected Info _FailureData;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Info_Description")]
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

    public FailureCauseDetails_Info Causes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Causes), (object) value);
      }
      get
      {
        return (FailureCauseDetails_Info) this.PropertyGet(nameof (Causes));
      }
    }

    public Info FailureData
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureData));
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
