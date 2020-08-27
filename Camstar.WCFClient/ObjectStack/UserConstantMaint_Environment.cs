// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserConstantMaint_Environment
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
  public class UserConstantMaint_Environment : TextVariableMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UserConstantMaint_Environment_ObjectChanges")]
    [Metadata("User Constant", "UserConstantChanges", false, false, false, "UserConstantChanges", 1048873, true, false, false, null)]
    protected UserConstantChanges_Environment _ObjectChanges;
    [Metadata("User Constant is used by the server when it sees a value in the expression like 'Constants::<name of a Constant>'", "UserConstant", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserConstantMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("User Constant is used by the server when it sees a value in the expression like 'Constants::<name of a Constant>'", "UserConstant", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserConstantMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public UserConstantChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UserConstantChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
