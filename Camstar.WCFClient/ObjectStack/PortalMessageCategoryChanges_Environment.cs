// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMessageCategoryChanges_Environment
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
  public class PortalMessageCategoryChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Portal Message Category consists of a single instance.   This single instance maintains mappings between a MessageCategory to one or more NotificationTypes along with details on where the messages will be displayed including order.", "PortalMessageCategory", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Environment_CategoryNotificationMap")]
    [Metadata("Defines a relationships between MessageCategory to one or more NotificationTypes along with details on where the messages will be displayed including order.", "CategoryNotificationMapChanges", false, true, false, "CategoryNotificationMapChanges", 1052309, false, true, false, null)]
    protected CategoryNotificationMapChanges_Environment _CategoryNotificationMap;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1052307, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Environment_YellowMinRange")]
    protected Environment _YellowMinRange;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1052308, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Environment_YellowMaxRange")]
    protected Environment _YellowMaxRange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052300, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public CategoryNotificationMapChanges_Environment CategoryNotificationMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryNotificationMap), (object) value);
      }
      get
      {
        return (CategoryNotificationMapChanges_Environment) this.PropertyGet(nameof (CategoryNotificationMap));
      }
    }

    public Environment YellowMinRange
    {
      [param: In] set
      {
        this.PropertySet(nameof (YellowMinRange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (YellowMinRange));
      }
    }

    public Environment YellowMaxRange
    {
      [param: In] set
      {
        this.PropertySet(nameof (YellowMaxRange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (YellowMaxRange));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
