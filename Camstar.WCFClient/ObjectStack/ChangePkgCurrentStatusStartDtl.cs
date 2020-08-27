// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePkgCurrentStatusStartDtl
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
  public class ChangePkgCurrentStatusStartDtl : TrackObjCurrentStatusStartDtls
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePkgCurrentStatusStartDtl_Workflow")]
    protected new RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangePkgCurrentStatusStartDtl_SpecStep")]
    protected new NamedSubentityRef _SpecStep;

    public override bool Equals(object obj)
    {
      return obj is ChangePkgCurrentStatusStartDtl && object.Equals((object) this._Workflow, (object) ((ChangePkgCurrentStatusStartDtl) obj)._Workflow) && object.Equals((object) this._SpecStep, (object) ((ChangePkgCurrentStatusStartDtl) obj)._SpecStep) && base.Equals(obj);
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

    public new NamedSubentityRef SpecStep
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
  }
}
