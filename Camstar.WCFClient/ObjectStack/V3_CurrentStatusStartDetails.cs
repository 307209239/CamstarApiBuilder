// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V3_CurrentStatusStartDetails
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
  public class V3_CurrentStatusStartDetails : CurrentStatusStartDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "V3_CurrentStatusStartDetails_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "V3_CurrentStatusStartDetails_Workflow")]
    protected new RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "V3_CurrentStatusStartDetails_Resource")]
    protected new NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "V3_CurrentStatusStartDetails_WorkflowStep")]
    protected new NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "V3_CurrentStatusStartDetails_Location")]
    protected new NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "V3_CurrentStatusStartDetails_WorkflowStack")]
    protected new NamedSubentityRef[] _WorkflowStack;

    public override bool Equals(object obj)
    {
      return obj is V3_CurrentStatusStartDetails && object.Equals((object) this._Factory, (object) ((V3_CurrentStatusStartDetails) obj)._Factory) && (object.Equals((object) this._Workflow, (object) ((V3_CurrentStatusStartDetails) obj)._Workflow) && object.Equals((object) this._Resource, (object) ((V3_CurrentStatusStartDetails) obj)._Resource)) && (object.Equals((object) this._WorkflowStep, (object) ((V3_CurrentStatusStartDetails) obj)._WorkflowStep) && object.Equals((object) this._Location, (object) ((V3_CurrentStatusStartDetails) obj)._Location) && this.CompareArrays((Array) this._WorkflowStack, (Array) ((V3_CurrentStatusStartDetails) obj)._WorkflowStack)) && base.Equals(obj);
    }

    public new NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }

    public new RevisionedObjectRef Workflow
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

    public new NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public new NamedSubentityRef WorkflowStep
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

    public new NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
      }
    }

    public new NamedSubentityRef[] WorkflowStack
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
  }
}
