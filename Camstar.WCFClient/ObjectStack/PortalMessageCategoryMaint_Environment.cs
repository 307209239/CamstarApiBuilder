// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMessageCategoryMaint_Environment
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
  public class PortalMessageCategoryMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryMaint_Environment_ObjectToChange")]
    [Metadata("Portal Message Category consists of a single instance.   This single instance maintains mappings between a MessageCategory to one or more NotificationTypes along with details on where the messages will be displayed including order.", "PortalMessageCategory", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Portal Message Category consists of a single instance.   This single instance maintains mappings between a MessageCategory to one or more NotificationTypes along with details on where the messages will be displayed including order.", "PortalMessageCategory", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PortalMessageCategoryMaint_Environment_ObjectChanges")]
    [Metadata("Portal Message Category consists of a single instance.   This single instance maintains mappings between a MessageCategory to one or more NotificationTypes along with details on where the messages will be displayed including order.", "PortalMessageCategoryChanges", false, false, false, "PortalMessageCategoryChanges", 1048873, true, false, false, null)]
    protected PortalMessageCategoryChanges_Environment _ObjectChanges;

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

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public PortalMessageCategoryChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PortalMessageCategoryChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
