// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryChanges_Environment
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
  public class UserQueryChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_Environment_UserQueryParameters")]
    [Metadata("Change object for UserQueryParameter.", "UserQueryParameterChanges", false, false, false, "UserQueryParameterChanges", 1049981, false, true, false, null)]
    protected UserQueryParameterChanges_Environment _UserQueryParameters;
    [Metadata("Predefined query defined using the Web Modeler application or using the new Web UI infrastructure and stored as Instance Data.  Note that the query definition is defined as instance data; the query itself can be used to retrieve information from either instance data tables or metadata tables.\r\nField UserQueryParameters will be implemented as a persistent list so that the parameter sequence will be automatically maintained by the corresponding persistent list table.", "UserQuery", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Query Text.", "", false, true, false, "String", 1050928, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_Environment_QueryText")]
    protected Environment _QueryText;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050127, false, false, false, null)]
    protected new Environment _Name;

    public UserQueryParameterChanges_Environment UserQueryParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryParameters), (object) value);
      }
      get
      {
        return (UserQueryParameterChanges_Environment) this.PropertyGet(nameof (UserQueryParameters));
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

    public Environment QueryText
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryText));
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
