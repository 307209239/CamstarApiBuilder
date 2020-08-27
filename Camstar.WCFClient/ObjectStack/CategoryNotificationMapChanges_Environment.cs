// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CategoryNotificationMapChanges_Environment
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
  public class CategoryNotificationMapChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Manages Categories available for use in PortalNotification.", "MessageCategoryLabel", false, true, false, "NamedObjectRef", 1052301, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Environment_MessageCategoryLabel")]
    protected Environment _MessageCategoryLabel;
    [Metadata("ConciergeType", "ConciergeTypeEnum", false, true, false, "Integer", 1052302, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Environment_NotificationTypes")]
    protected Environment _NotificationTypes;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052303, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Environment_DisplayInMessageCenter")]
    protected Environment _DisplayInMessageCenter;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Environment_Sequence")]
    protected Environment _Sequence;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052304, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Environment_DisplayInConcierge")]
    protected Environment _DisplayInConcierge;
    [DataMember(EmitDefaultValue = false, Name = "CategoryNotificationMapChanges_Environment_Icon")]
    [Metadata("Generic String", "", false, false, false, "String", 1052325, false, false, false, null)]
    protected Environment _Icon;

    public Environment MessageCategoryLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoryLabel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MessageCategoryLabel));
      }
    }

    public Environment NotificationTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotificationTypes));
      }
    }

    public Environment DisplayInMessageCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayInMessageCenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayInMessageCenter));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment DisplayInConcierge
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayInConcierge), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayInConcierge));
      }
    }

    public Environment Icon
    {
      [param: In] set
      {
        this.PropertySet(nameof (Icon), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Icon));
      }
    }
  }
}
