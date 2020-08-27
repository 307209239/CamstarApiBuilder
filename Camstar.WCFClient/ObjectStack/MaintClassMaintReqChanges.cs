// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintClassMaintReqChanges
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
  public class MaintClassMaintReqChanges : AssignedMaintReqChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqChanges_Parent")]
    protected NamedObjectRef _Parent;

    public override bool Equals(object obj)
    {
      return obj is MaintClassMaintReqChanges && object.Equals((object) this._ObjectToChange, (object) ((MaintClassMaintReqChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((MaintClassMaintReqChanges) obj)._ListItemToChange) && object.Equals((object) this._Parent, (object) ((MaintClassMaintReqChanges) obj)._Parent)) && base.Equals(obj);
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

    public NamedObjectRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Parent));
      }
    }
  }
}
