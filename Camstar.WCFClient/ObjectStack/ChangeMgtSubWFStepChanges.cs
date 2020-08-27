// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtSubWFStepChanges
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
  public class ChangeMgtSubWFStepChanges : BPSubWorkflowStepChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSubWFStepChanges_SubWorkflow")]
    protected new RevisionedObjectRef _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSubWFStepChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is ChangeMgtSubWFStepChanges && object.Equals((object) this._SubWorkflow, (object) ((ChangeMgtSubWFStepChanges) obj)._SubWorkflow) && object.Equals((object) this._ObjectToChange, (object) ((ChangeMgtSubWFStepChanges) obj)._ObjectToChange) && base.Equals(obj);
    }

    public new RevisionedObjectRef SubWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SubWorkflow));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
