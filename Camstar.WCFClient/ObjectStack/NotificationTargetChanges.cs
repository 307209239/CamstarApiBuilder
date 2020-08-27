// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NotificationTargetChanges
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
  public class NotificationTargetChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetChanges_DeliveryMethod")]
    protected Enumeration<DeliveryMethodEnum, int> _DeliveryMethod;
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is NotificationTargetChanges && object.Equals((object) this._DeliveryMethod, (object) ((NotificationTargetChanges) obj)._DeliveryMethod) && (object.Equals((object) this._ObjectToChange, (object) ((NotificationTargetChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((NotificationTargetChanges) obj)._Name)) && base.Equals(obj);
    }

    public Enumeration<DeliveryMethodEnum, int> DeliveryMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryMethod), (object) value);
      }
      get
      {
        return (Enumeration<DeliveryMethodEnum, int>) this.PropertyGet(nameof (DeliveryMethod));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
