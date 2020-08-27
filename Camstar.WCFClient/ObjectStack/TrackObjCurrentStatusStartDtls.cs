// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackObjCurrentStatusStartDtls
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChangePkgCurrentStatusStartDtl))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class TrackObjCurrentStatusStartDtls : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackObjCurrentStatusStartDtls_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "TrackObjCurrentStatusStartDtls_WorkflowStack")]
    protected NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "TrackObjCurrentStatusStartDtls_SpecStep")]
    protected NamedSubentityRef _SpecStep;
    [DataMember(EmitDefaultValue = false, Name = "TrackObjCurrentStatusStartDtls_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;

    public override bool Equals(object obj)
    {
      return obj is TrackObjCurrentStatusStartDtls && object.Equals((object) this._Workflow, (object) ((TrackObjCurrentStatusStartDtls) obj)._Workflow) && (this.CompareArrays((Array) this._WorkflowStack, (Array) ((TrackObjCurrentStatusStartDtls) obj)._WorkflowStack) && object.Equals((object) this._SpecStep, (object) ((TrackObjCurrentStatusStartDtls) obj)._SpecStep)) && object.Equals((object) this._WorkflowStep, (object) ((TrackObjCurrentStatusStartDtls) obj)._WorkflowStep) && base.Equals(obj);
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

    public NamedSubentityRef[] WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public NamedSubentityRef SpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (SpecStep));
      }
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
  }
}
