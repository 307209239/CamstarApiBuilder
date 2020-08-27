// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveTxns
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
  public class MoveTxns : ContainersTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Services")]
    protected MoveTxn[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_ToWorkflowStack")]
    protected NamedSubentityRef[] _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_ClearToWorkflowStack")]
    protected Primitive<bool> _ClearToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_ToFactory")]
    protected NamedObjectRef _ToFactory;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_ToLocation")]
    protected NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_ToWorkflow")]
    protected RevisionedObjectRef _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_ToStep")]
    protected NamedSubentityRef _ToStep;

    public override bool Equals(object obj)
    {
      return obj is MoveTxns && this.CompareArrays((Array) this._Services, (Array) ((MoveTxns) obj)._Services) && (this.CompareArrays((Array) this._ToWorkflowStack, (Array) ((MoveTxns) obj)._ToWorkflowStack) && object.Equals((object) this._ClearToWorkflowStack, (object) ((MoveTxns) obj)._ClearToWorkflowStack)) && (object.Equals((object) this._Resource, (object) ((MoveTxns) obj)._Resource) && object.Equals((object) this._ToFactory, (object) ((MoveTxns) obj)._ToFactory) && (object.Equals((object) this._ToLocation, (object) ((MoveTxns) obj)._ToLocation) && object.Equals((object) this._ToWorkflow, (object) ((MoveTxns) obj)._ToWorkflow))) && object.Equals((object) this._ToStep, (object) ((MoveTxns) obj)._ToStep) && base.Equals(obj);
    }

    public MoveTxn[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (MoveTxn[]) this.PropertyGet(nameof (Services));
      }
    }

    public NamedSubentityRef[] ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ToWorkflowStack));
      }
    }

    public Primitive<bool> ClearToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearToWorkflowStack), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ClearToWorkflowStack));
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

    public NamedObjectRef ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToFactory));
      }
    }

    public NamedSubentityRef ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToLocation));
      }
    }

    public RevisionedObjectRef ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
      }
    }
  }
}
