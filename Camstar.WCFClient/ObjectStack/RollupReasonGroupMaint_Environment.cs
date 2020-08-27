// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RollupReasonGroupMaint_Environment
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
  public class RollupReasonGroupMaint_Environment : UserCodeGroupMaint_Environment
  {
    [Metadata("A User Code Object Group that represents a group of Rollup Reasons.", "RollupReasonGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RollupReasonGroupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A User Code Object Group that represents a group of Rollup Reasons.", "RollupReasonGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RollupReasonGroupMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "RollupReasonGroupMaint_Environment_ObjectChanges")]
    [Metadata("Rollup Reason Group Changes", "RollupReasonGroupChanges", false, false, false, "RollupReasonGroupChanges", 1048873, true, false, false, null)]
    protected RollupReasonGroupChanges_Environment _ObjectChanges;

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

    public RollupReasonGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RollupReasonGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
