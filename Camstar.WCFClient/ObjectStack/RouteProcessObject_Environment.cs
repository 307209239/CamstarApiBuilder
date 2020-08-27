// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteProcessObject_Environment
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
  public class RouteProcessObject_Environment : ProcessObjectTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RouteProcessObject_Environment_ChildRoutingOption")]
    [Metadata("Enumeration for the Child Routing Option:\r\n1 = NoChange\r\n2 = FromPending", "ChildRoutingOptionEnum", false, false, false, "Integer", 1052127, false, false, true, "1")]
    protected Environment _ChildRoutingOption;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1051372, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RouteProcessObject_Environment_Assignee")]
    protected Environment _Assignee;

    public Environment ChildRoutingOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildRoutingOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildRoutingOption));
      }
    }

    public Environment Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Assignee));
      }
    }
  }
}
