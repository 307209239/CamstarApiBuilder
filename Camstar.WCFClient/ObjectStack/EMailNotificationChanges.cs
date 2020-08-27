// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailNotificationChanges
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
  public class EMailNotificationChanges : NotificationTargetChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Recipient")]
    protected Primitive<string> _Recipient;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Sender")]
    protected Primitive<string> _Sender;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_DeliveryMethod")]
    protected new Enumeration<DeliveryMethodEnum, int> _DeliveryMethod;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_EMailProfile")]
    protected Primitive<string> _EMailProfile;

    public override bool Equals(object obj)
    {
      return obj is EMailNotificationChanges && object.Equals((object) this._Recipient, (object) ((EMailNotificationChanges) obj)._Recipient) && (object.Equals((object) this._Sender, (object) ((EMailNotificationChanges) obj)._Sender) && object.Equals((object) this._ObjectToChange, (object) ((EMailNotificationChanges) obj)._ObjectToChange)) && (object.Equals((object) this._Name, (object) ((EMailNotificationChanges) obj)._Name) && object.Equals((object) this._DeliveryMethod, (object) ((EMailNotificationChanges) obj)._DeliveryMethod) && object.Equals((object) this._EMailProfile, (object) ((EMailNotificationChanges) obj)._EMailProfile)) && base.Equals(obj);
    }

    public Primitive<string> Recipient
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recipient), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Recipient));
      }
    }

    public Primitive<string> Sender
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sender), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Sender));
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

    public new Enumeration<DeliveryMethodEnum, int> DeliveryMethod
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

    public Primitive<string> EMailProfile
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailProfile), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EMailProfile));
      }
    }
  }
}
