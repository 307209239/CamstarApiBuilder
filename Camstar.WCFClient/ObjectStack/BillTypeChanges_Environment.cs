// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillTypeChanges_Environment
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
  public class BillTypeChanges_Environment : UserCodeChanges_Environment
  {
    [Metadata("Used to distinguish the intent of this Bill structure. Several Bills can exist for the same product. Bills can be at higher or lower levels of resolution depending on the department that is using the Bill. Items that are not physically part of the manufacturing process can be added to assist standard costing calculations or labor reporting.", "BillType", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillTypeChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050099, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillTypeChanges_Environment_Name")]
    protected new Environment _Name;

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
