// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryGroupMaint_Environment
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
  public class UserQueryGroupMaint_Environment : NamedObjectGroupMaint_Environment
  {
    [Metadata("Used to create groupings of user queries. Usually used to group outputs.", "UserQueryGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryGroupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryGroupMaint_Environment_ObjectListInquiry")]
    [Metadata("Used to create groupings of user queries. Usually used to group outputs.", "UserQueryGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Used to create groupings of user queries. Usually used to group outputs.", "UserQueryGroupChanges", false, false, false, "UserQueryGroupChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryGroupMaint_Environment_ObjectChanges")]
    protected UserQueryGroupChanges_Environment _ObjectChanges;

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

    public UserQueryGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UserQueryGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
