// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MatlContainerCurrentStartDtls
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
  public class MatlContainerCurrentStartDtls : CurrentStatusStartDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "MatlContainerCurrentStartDtls_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MatlContainerCurrentStartDtls_Carrier")]
    protected new NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "MatlContainerCurrentStartDtls_WorkflowStep")]
    protected new NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "MatlContainerCurrentStartDtls_Workflow")]
    protected new RevisionedObjectRef _Workflow;

    public override bool Equals(object obj)
    {
      return obj is MatlContainerCurrentStartDtls && object.Equals((object) this._Spec, (object) ((MatlContainerCurrentStartDtls) obj)._Spec) && (object.Equals((object) this._Carrier, (object) ((MatlContainerCurrentStartDtls) obj)._Carrier) && object.Equals((object) this._WorkflowStep, (object) ((MatlContainerCurrentStartDtls) obj)._WorkflowStep)) && object.Equals((object) this._Workflow, (object) ((MatlContainerCurrentStartDtls) obj)._Workflow) && base.Equals(obj);
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public new NamedObjectRef Carrier
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
  }
}
