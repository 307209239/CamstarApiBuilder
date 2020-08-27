// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPStartTxn
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
  public class BPStartTxn : BusinessProcessTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_CurrentStatusDetails")]
    protected TrackObjCurrentStatusStartDtls _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_TrackableObject")]
    protected new BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "BPStartTxn_TrackableName")]
    protected Primitive<string> _TrackableName;

    public override bool Equals(object obj)
    {
      return obj is BPStartTxn && object.Equals((object) this._Workflow, (object) ((BPStartTxn) obj)._Workflow) && (object.Equals((object) this._CurrentStatusDetails, (object) ((BPStartTxn) obj)._CurrentStatusDetails) && object.Equals((object) this._TrackableObject, (object) ((BPStartTxn) obj)._TrackableObject)) && object.Equals((object) this._TrackableName, (object) ((BPStartTxn) obj)._TrackableName) && base.Equals(obj);
    }

    public RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
      }
    }

    public TrackObjCurrentStatusStartDtls CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (TrackObjCurrentStatusStartDtls) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }

    public new BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Primitive<string> TrackableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TrackableName));
      }
    }
  }
}
