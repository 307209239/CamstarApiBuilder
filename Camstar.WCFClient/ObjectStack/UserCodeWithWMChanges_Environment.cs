// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserCodeWithWMChanges_Environment
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
  public class UserCodeWithWMChanges_Environment : UserCodeChanges_Environment
  {
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_Environment_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_Environment_ChangeHistory")]
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    protected new ChangeHistoryChanges_Environment _ChangeHistory;
    [Metadata("User Defined Codes are used to allow each customer to specify a list of allowable values for a specific field. In many cases a User Defined Code will merely consist of a Name and Description with no additional attributes. User Defined Codes can also have associated WIP Messages, if they are associated with a field from a Container Definition. They may also include additional attributes, typically used for additional validations.\r\n\r\nThe name for each Code must be unique within its type. This value is used as an alternate key for lookup-up, data entry and validation.\r\n\r\nThis document includes a section that describes each Type of User Defined Code delivered with Pajaro. Each type equates to a CDO Definition.", "UserCodeWithWM", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050198, false, false, false, null)]
    protected new Environment _Name;

    public WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public new ChangeHistoryChanges_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

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
