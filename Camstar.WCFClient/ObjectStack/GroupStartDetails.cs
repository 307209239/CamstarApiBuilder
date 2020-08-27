// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GroupStartDetails
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
  public class GroupStartDetails : StartDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_ChildContainers")]
    protected UnitStartDetails[] _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_SpecStep")]
    protected NamedSubentityRef _SpecStep;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_WorkflowStack")]
    protected NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Location")]
    protected NamedSubentityRef _Location;

    public override bool Equals(object obj)
    {
      return obj is GroupStartDetails && this.CompareArrays((Array) this._ChildContainers, (Array) ((GroupStartDetails) obj)._ChildContainers) && (object.Equals((object) this._SpecStep, (object) ((GroupStartDetails) obj)._SpecStep) && this.CompareArrays((Array) this._WorkflowStack, (Array) ((GroupStartDetails) obj)._WorkflowStack)) && (object.Equals((object) this._Factory, (object) ((GroupStartDetails) obj)._Factory) && object.Equals((object) this._WorkflowStep, (object) ((GroupStartDetails) obj)._WorkflowStep) && (object.Equals((object) this._Resource, (object) ((GroupStartDetails) obj)._Resource) && object.Equals((object) this._Workflow, (object) ((GroupStartDetails) obj)._Workflow))) && object.Equals((object) this._Location, (object) ((GroupStartDetails) obj)._Location) && base.Equals(obj);
    }

    public UnitStartDetails[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (UnitStartDetails[]) this.PropertyGet(nameof (ChildContainers));
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

    public NamedObjectRef Factory
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

    public NamedObjectRef Resource
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

    public NamedSubentityRef Location
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
  }
}
