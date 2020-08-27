// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObjectGroupMaint_Environment
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
  public class RevisionedObjectGroupMaint_Environment : ObjectGroupMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupMaint_Environment_ObjectListInquiry")]
    [Metadata("RevisionedObjectGroup is used to provide a list of revisioned object.\r\n", "RevisionedObjectGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("RevisionedObjectGroup is used to provide a list of revisioned object.\r\n", "RevisionedObjectGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO for RevisionedObjectGroup.", "RevisionedObjectGroupChanges", false, false, false, "RevisionedObjectGroupChanges", 1048873, true, false, false, null)]
    protected RevisionedObjectGroupChanges_Environment _ObjectChanges;

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

    public RevisionedObjectGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RevisionedObjectGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
