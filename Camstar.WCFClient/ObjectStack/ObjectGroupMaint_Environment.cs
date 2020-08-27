// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectGroupMaint_Environment
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
  public class ObjectGroupMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Changes CDO for ObjectGroup.", "ObjectGroupChanges", false, false, false, "ObjectGroupChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupMaint_Environment_ObjectChanges")]
    protected ObjectGroupChanges_Environment _ObjectChanges;
    [Metadata("An ObjectGroup is used to provide a list of objects, such as a list of Resources, Products or User Codes of a particular type. These lists are typically used for validation and selection. For example, an Operation includes a reference to a LossCodeGroup. The entries in this list define the valid Loss (reason) Codes for work performed while a Container is at that Operation.\r\n\r\nAn instance of an ObjectGroup includes a list of specific objects and a list of ObjectGroups. This list of objects for any given ObjectGroup is restricted to a specific type (or any of its derived types). Likewise, the list of ObjectGroup s within the ObjectGroup is restricted to the same type (or any of its derived types).\r\n", "ObjectGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("An ObjectGroup is used to provide a list of objects, such as a list of Resources, Products or User Codes of a particular type. These lists are typically used for validation and selection. For example, an Operation includes a reference to a LossCodeGroup. The entries in this list define the valid Loss (reason) Codes for work performed while a Container is at that Operation.\r\n\r\nAn instance of an ObjectGroup includes a list of specific objects and a list of ObjectGroups. This list of objects for any given ObjectGroup is restricted to a specific type (or any of its derived types). Likewise, the list of ObjectGroup s within the ObjectGroup is restricted to the same type (or any of its derived types).\r\n", "ObjectGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public ObjectGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ObjectGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
