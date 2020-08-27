// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionDetails
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
  public class ActionDetails : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionDetails_IsEnabled")]
    protected Primitive<bool> _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "ActionDetails_Action")]
    protected NamedObjectRef _Action;

    public override bool Equals(object obj)
    {
      return obj is ActionDetails && object.Equals((object) this._IsEnabled, (object) ((ActionDetails) obj)._IsEnabled) && object.Equals((object) this._Action, (object) ((ActionDetails) obj)._Action) && base.Equals(obj);
    }

    public Primitive<bool> IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public NamedObjectRef Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Action));
      }
    }
  }
}
