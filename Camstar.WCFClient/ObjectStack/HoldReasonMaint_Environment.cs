// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldReasonMaint_Environment
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
  public class HoldReasonMaint_Environment : UserCodeWithWMMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "HoldReasonMaint_Environment_ObjectToChange")]
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "HoldReasonMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Changes CDO for HoldReason.", "HoldReasonChanges", false, false, false, "HoldReasonChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HoldReasonMaint_Environment_ObjectChanges")]
    protected HoldReasonChanges_Environment _ObjectChanges;

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

    public HoldReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (HoldReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
