// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillTypeMaint_Environment
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
  public class BillTypeMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("Changes CDO for BillType.", "BillTypeChanges", false, false, false, "BillTypeChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillTypeMaint_Environment_ObjectChanges")]
    protected BillTypeChanges_Environment _ObjectChanges;
    [Metadata("Used to distinguish the intent of this Bill structure. Several Bills can exist for the same product. Bills can be at higher or lower levels of resolution depending on the department that is using the Bill. Items that are not physically part of the manufacturing process can be added to assist standard costing calculations or labor reporting.", "BillType", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillTypeMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Used to distinguish the intent of this Bill structure. Several Bills can exist for the same product. Bills can be at higher or lower levels of resolution depending on the department that is using the Bill. Items that are not physically part of the manufacturing process can be added to assist standard costing calculations or labor reporting.", "BillType", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillTypeMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public BillTypeChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (BillTypeChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
