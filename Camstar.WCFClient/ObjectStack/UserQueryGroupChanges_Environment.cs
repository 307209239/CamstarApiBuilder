// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryGroupChanges_Environment
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
  public class UserQueryGroupChanges_Environment : NamedObjectGroupChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UserQueryGroupChanges_Environment_ResolvedEntries")]
    [Metadata("Predefined query defined using the Web Modeler application or using the new Web UI infrastructure and stored as Instance Data.  Note that the query definition is defined as instance data; the query itself can be used to retrieve information from either instance data tables or metadata tables.\r\nField UserQueryParameters will be implemented as a persistent list so that the parameter sequence will be automatically maintained by the corresponding persistent list table.", "UserQuery", false, false, true, "NamedObjectRef", 1048760, false, true, true, null)]
    protected new Environment _ResolvedEntries;
    [Metadata("Predefined query defined using the Web Modeler application or using the new Web UI infrastructure and stored as Instance Data.  Note that the query definition is defined as instance data; the query itself can be used to retrieve information from either instance data tables or metadata tables.\r\nField UserQueryParameters will be implemented as a persistent list so that the parameter sequence will be automatically maintained by the corresponding persistent list table.", "UserQuery", false, false, false, "NamedObjectRef", 1048631, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryGroupChanges_Environment_Entries")]
    protected new Environment _Entries;
    [Metadata("Used to create groupings of user queries. Usually used to group outputs.", "UserQueryGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryGroupChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryGroupChanges_Environment_Groups")]
    [Metadata("Used to create groupings of user queries. Usually used to group outputs.", "UserQueryGroup", false, false, false, "NamedObjectRef", 1048633, false, true, true, null)]
    protected new Environment _Groups;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048632, false, false, true, "UserQuery")]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryGroupChanges_Environment_EntryType")]
    protected new Environment _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryGroupChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052827, false, false, false, null)]
    protected new Environment _Name;

    public new Environment ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolvedEntries));
      }
    }

    public new Environment Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Entries));
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

    public new Environment Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Groups));
      }
    }

    public new Environment EntryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EntryType));
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
