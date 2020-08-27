// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserCodeWithWMMaint_Environment
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
  public class UserCodeWithWMMaint_Environment : UserCodeMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO for UserCodeWithWM.", "UserCodeWithWMChanges", false, false, false, "UserCodeWithWMChanges", 1048873, true, false, false, null)]
    protected UserCodeWithWMChanges_Environment _ObjectChanges;
    [Metadata("User Defined Codes are used to allow each customer to specify a list of allowable values for a specific field. In many cases a User Defined Code will merely consist of a Name and Description with no additional attributes. User Defined Codes can also have associated WIP Messages, if they are associated with a field from a Container Definition. They may also include additional attributes, typically used for additional validations.\r\n\r\nThe name for each Code must be unique within its type. This value is used as an alternate key for lookup-up, data entry and validation.\r\n\r\nThis document includes a section that describes each Type of User Defined Code delivered with Pajaro. Each type equates to a CDO Definition.", "UserCodeWithWM", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("User Defined Codes are used to allow each customer to specify a list of allowable values for a specific field. In many cases a User Defined Code will merely consist of a Name and Description with no additional attributes. User Defined Codes can also have associated WIP Messages, if they are associated with a field from a Container Definition. They may also include additional attributes, typically used for additional validations.\r\n\r\nThe name for each Code must be unique within its type. This value is used as an alternate key for lookup-up, data entry and validation.\r\n\r\nThis document includes a section that describes each Type of User Defined Code delivered with Pajaro. Each type equates to a CDO Definition.", "UserCodeWithWM", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserCodeWithWMMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public UserCodeWithWMChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UserCodeWithWMChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
