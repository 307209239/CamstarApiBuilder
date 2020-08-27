// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CategoryNotificationMapChanges_Info
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
  public class CategoryNotificationMapChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Info_MessageCategoryLabel")]
    protected Info _MessageCategoryLabel;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Info_NotificationTypes")]
    protected Info _NotificationTypes;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Info_DisplayInMessageCenter")]
    protected Info _DisplayInMessageCenter;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Info_DisplayInConcierge")]
    protected Info _DisplayInConcierge;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Info_Icon")]
    protected Info _Icon;

    public Info MessageCategoryLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoryLabel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MessageCategoryLabel));
      }
    }

    public Info NotificationTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotificationTypes));
      }
    }

    public Info DisplayInMessageCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayInMessageCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayInMessageCenter));
      }
    }

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info DisplayInConcierge
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayInConcierge), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayInConcierge));
      }
    }

    public Info Icon
    {
      [param: In] set
      {
        this.PropertySet(nameof (Icon), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Icon));
      }
    }
  }
}
