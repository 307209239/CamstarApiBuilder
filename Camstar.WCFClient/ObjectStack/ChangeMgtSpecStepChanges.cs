// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtSpecStepChanges
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
  public class ChangeMgtSpecStepChanges : BusinessProcessSpecStepChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecStepChanges_Spec")]
    protected new RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecStepChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is ChangeMgtSpecStepChanges && object.Equals((object) this._Spec, (object) ((ChangeMgtSpecStepChanges) obj)._Spec) && object.Equals((object) this._ObjectToChange, (object) ((ChangeMgtSpecStepChanges) obj)._ObjectToChange) && base.Equals(obj);
    }

    public new RevisionedObjectRef Spec
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
