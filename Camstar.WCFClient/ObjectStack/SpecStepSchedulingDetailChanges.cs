// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecStepSchedulingDetailChanges
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
  public class SpecStepSchedulingDetailChanges : StepSchedulingDetailChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SpecStepSchedulingDetailChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;

    public override bool Equals(object obj)
    {
      return obj is SpecStepSchedulingDetailChanges && object.Equals((object) this._ObjectToChange, (object) ((SpecStepSchedulingDetailChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((SpecStepSchedulingDetailChanges) obj)._ListItemToChange) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }
  }
}
