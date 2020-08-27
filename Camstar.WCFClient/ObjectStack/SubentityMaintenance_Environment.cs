// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityMaintenance_Environment
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
  public class SubentityMaintenance_Environment : Maintenance_Environment
  {
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO.  SubEntityChanges are used as temporary holding places while the parent CDO is undergoing maintenance.", "SubentityChanges", false, false, false, "SubentityChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubentityMaintenance_Environment_ObjectChanges")]
    protected SubentityChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "SubentityMaintenance_Environment_ObjectToChange")]
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO. This typically equates to a list-type field within a Modeling CDO.", "Subentity", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubentityMaintenance_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "SubentityMaintenance_Environment_ParentDataObject")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1050488, false, false, false, null)]
    protected Environment _ParentDataObject;

    public SubentityChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SubentityChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public Environment ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
