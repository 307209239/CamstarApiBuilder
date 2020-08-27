// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CategoryNotificationMapChanges
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
  public class CategoryNotificationMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_MessageCategoryLabel")]
    protected NamedObjectRef _MessageCategoryLabel;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_NotificationTypes")]
    protected Enumeration<ConciergeTypeEnum, int>[] _NotificationTypes;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_DisplayInMessageCenter")]
    protected Primitive<bool> _DisplayInMessageCenter;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_DisplayInConcierge")]
    protected Primitive<bool> _DisplayInConcierge;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Icon")]
    protected Primitive<string> _Icon;

    public override bool Equals(object obj)
    {
      return obj is CategoryNotificationMapChanges && object.Equals((object) this._MessageCategoryLabel, (object) ((CategoryNotificationMapChanges) obj)._MessageCategoryLabel) && (this.CompareArrays((Array) this._NotificationTypes, (Array) ((CategoryNotificationMapChanges) obj)._NotificationTypes) && object.Equals((object) this._DisplayInMessageCenter, (object) ((CategoryNotificationMapChanges) obj)._DisplayInMessageCenter)) && (object.Equals((object) this._Sequence, (object) ((CategoryNotificationMapChanges) obj)._Sequence) && object.Equals((object) this._DisplayInConcierge, (object) ((CategoryNotificationMapChanges) obj)._DisplayInConcierge) && object.Equals((object) this._Icon, (object) ((CategoryNotificationMapChanges) obj)._Icon)) && base.Equals(obj);
    }

    public NamedObjectRef MessageCategoryLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoryLabel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MessageCategoryLabel));
      }
    }

    public Enumeration<ConciergeTypeEnum, int>[] NotificationTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationTypes), (object) value);
      }
      get
      {
        return (Enumeration<ConciergeTypeEnum, int>[]) this.PropertyGet(nameof (NotificationTypes));
      }
    }

    public Primitive<bool> DisplayInMessageCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayInMessageCenter), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayInMessageCenter));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Primitive<bool> DisplayInConcierge
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayInConcierge), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayInConcierge));
      }
    }

    public Primitive<string> Icon
    {
      [param: In] set
      {
        this.PropertySet(nameof (Icon), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Icon));
      }
    }
  }
}
