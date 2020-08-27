// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryMaint_Environment
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
  public class UserQueryMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Predefined query defined using the Web Modeler application or using the new Web UI infrastructure and stored as Instance Data.  Note that the query definition is defined as instance data; the query itself can be used to retrieve information from either instance data tables or metadata tables.\r\nField UserQueryParameters will be implemented as a persistent list so that the parameter sequence will be automatically maintained by the corresponding persistent list table.", "UserQuery", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Predefined query defined using the Web Modeler application or using the new Web UI infrastructure and stored as Instance Data.  Note that the query definition is defined as instance data; the query itself can be used to retrieve information from either instance data tables or metadata tables.\r\nField UserQueryParameters will be implemented as a persistent list so that the parameter sequence will be automatically maintained by the corresponding persistent list table.", "UserQuery", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Predefined query defined using the Web Modeler application or using the new Web UI infrastructure and stored as Instance Data.  Note that the query definition is defined as instance data; the query itself can be used to retrieve information from either instance data tables or metadata tables.\r\nField UserQueryParameters will be implemented as a persistent list so that the parameter sequence will be automatically maintained by the corresponding persistent list table.", "UserQueryChanges", false, false, false, "UserQueryChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryMaint_Environment_ObjectChanges")]
    protected UserQueryChanges_Environment _ObjectChanges;

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

    public UserQueryChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UserQueryChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
