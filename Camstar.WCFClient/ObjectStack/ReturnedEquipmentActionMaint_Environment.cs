// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReturnedEquipmentActionMaint_Environment
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
  public class ReturnedEquipmentActionMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("Action taken for returned equipment.", "ReturnedEquipmentActionChanges", false, false, false, "ReturnedEquipmentActionChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReturnedEquipmentActionMaint_Environment_ObjectChanges")]
    protected ReturnedEquipmentActionChanges_Environment _ObjectChanges;
    [Metadata("Action taken for returned equipment.", "ReturnedEquipmentAction", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReturnedEquipmentActionMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ReturnedEquipmentActionMaint_Environment_ObjectListInquiry")]
    [Metadata("Action taken for returned equipment.", "ReturnedEquipmentAction", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;

    public ReturnedEquipmentActionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ReturnedEquipmentActionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
