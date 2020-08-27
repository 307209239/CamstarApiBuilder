// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemoveDifferenceReasonMaint_Environment
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
  public class RemoveDifferenceReasonMaint_Environment : UserCodeMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RemoveDifferenceReasonMaint_Environment_ObjectToChange")]
    [Metadata("The reasons that a difference between the quantity that was issued and the quantity that was removed might exist.", "RemoveDifferenceReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RemoveDifferenceReasonMaint_Environment_ObjectListInquiry")]
    [Metadata("The reasons that a difference between the quantity that was issued and the quantity that was removed might exist.", "RemoveDifferenceReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("The reasons that a difference between the quantity that was issued and the quantity that was removed might exist.", "RemoveDifferenceReasonChanges", false, false, false, "RemoveDifferenceReasonChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemoveDifferenceReasonMaint_Environment_ObjectChanges")]
    protected RemoveDifferenceReasonChanges_Environment _ObjectChanges;

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

    public RemoveDifferenceReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RemoveDifferenceReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
