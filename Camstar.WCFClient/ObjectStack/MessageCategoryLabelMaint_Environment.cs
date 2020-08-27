// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MessageCategoryLabelMaint_Environment
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
  public class MessageCategoryLabelMaint_Environment : UserLabelMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelMaint_Environment_ObjectToChange")]
    [Metadata("Manages Categories available for use in PortalNotification.", "MessageCategoryLabel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Message Category Definition that can be displayed in Concierge and Message Center in Quality.", "MessageCategoryLabelChanges", false, false, false, "MessageCategoryLabelChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelMaint_Environment_ObjectChanges")]
    protected MessageCategoryLabelChanges_Environment _ObjectChanges;
    [Metadata("Manages Categories available for use in PortalNotification.", "MessageCategoryLabel", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

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

    public MessageCategoryLabelChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (MessageCategoryLabelChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
