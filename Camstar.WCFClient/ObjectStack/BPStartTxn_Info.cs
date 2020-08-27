// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPStartTxn_Info
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
  public class BPStartTxn_Info : BusinessProcessTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_Info_CurrentStatusDetails")]
    protected TrackObjCurrentStatusStartDtls_Info _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_Info_TrackableObject")]
    protected new Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_Info_TrackableName")]
    protected Info _TrackableName;

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public TrackObjCurrentStatusStartDtls_Info CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (TrackObjCurrentStatusStartDtls_Info) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }

    public new Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Info TrackableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableName));
      }
    }
  }
}
