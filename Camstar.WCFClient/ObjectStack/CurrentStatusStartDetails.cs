// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentStatusStartDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MatlContainerCurrentStartDtls))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (V3_CurrentStatusStartDetails))]
  [Serializable]
  public class CurrentStatusStartDetails : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_ReworkStatusStartDetails")]
    protected Camstar.WCF.ObjectStack.ReworkStatusStartDetails[] _ReworkStatusStartDetails;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_ReworkTotalCount")]
    protected Primitive<int> _ReworkTotalCount;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_InRework")]
    protected Primitive<bool> _InRework;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_InProcess")]
    protected Primitive<bool> _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_WorkflowStack")]
    protected NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Location")]
    protected NamedSubentityRef _Location;

    public override bool Equals(object obj)
    {
      return obj is CurrentStatusStartDetails && this.CompareArrays((Array) this._ReworkStatusStartDetails, (Array) ((CurrentStatusStartDetails) obj)._ReworkStatusStartDetails) && (object.Equals((object) this._Carrier, (object) ((CurrentStatusStartDetails) obj)._Carrier) && object.Equals((object) this._ReworkTotalCount, (object) ((CurrentStatusStartDetails) obj)._ReworkTotalCount)) && (object.Equals((object) this._InRework, (object) ((CurrentStatusStartDetails) obj)._InRework) && object.Equals((object) this._InProcess, (object) ((CurrentStatusStartDetails) obj)._InProcess) && (object.Equals((object) this._Workflow, (object) ((CurrentStatusStartDetails) obj)._Workflow) && object.Equals((object) this._Resource, (object) ((CurrentStatusStartDetails) obj)._Resource))) && (object.Equals((object) this._WorkflowStep, (object) ((CurrentStatusStartDetails) obj)._WorkflowStep) && this.CompareArrays((Array) this._WorkflowStack, (Array) ((CurrentStatusStartDetails) obj)._WorkflowStack) && (object.Equals((object) this._Factory, (object) ((CurrentStatusStartDetails) obj)._Factory) && object.Equals((object) this._Location, (object) ((CurrentStatusStartDetails) obj)._Location))) && base.Equals(obj);
    }

    public Camstar.WCF.ObjectStack.ReworkStatusStartDetails[] ReworkStatusStartDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkStatusStartDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ReworkStatusStartDetails[]) this.PropertyGet(nameof (ReworkStatusStartDetails));
      }
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public Primitive<int> ReworkTotalCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkTotalCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ReworkTotalCount));
      }
    }

    public Primitive<bool> InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InRework));
      }
    }

    public Primitive<bool> InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InProcess));
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
