// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentResourceStatusChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ResourceLogChanges))]
  [KnownType(typeof (PMStatusChanges))]
  [Serializable]
  public class CurrentResourceStatusChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_Reason")]
    protected NamedObjectRef _Reason;
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_Status")]
    protected NamedObjectRef _Status;

    public override bool Equals(object obj)
    {
      return obj is CurrentResourceStatusChanges && object.Equals((object) this._ListItemToChange, (object) ((CurrentResourceStatusChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((CurrentResourceStatusChanges) obj)._ObjectToChange) && object.Equals((object) this._Comments, (object) ((CurrentResourceStatusChanges) obj)._Comments)) && (object.Equals((object) this._Reason, (object) ((CurrentResourceStatusChanges) obj)._Reason) && object.Equals((object) this._Status, (object) ((CurrentResourceStatusChanges) obj)._Status)) && base.Equals(obj);
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

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public NamedObjectRef Reason
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Reason));
      }
    }

    public NamedObjectRef Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Status));
      }
    }
  }
}
