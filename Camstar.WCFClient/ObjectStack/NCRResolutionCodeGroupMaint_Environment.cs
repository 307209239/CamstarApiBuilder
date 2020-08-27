// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRResolutionCodeGroupMaint_Environment
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
  public class NCRResolutionCodeGroupMaint_Environment : UserCodeGroupMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupMaint_Environment_ObjectChanges")]
    [Metadata("A User Code Object Group that represents a group of NCRResolutionCodes.", "NCRResolutionCodeGroupChanges", false, false, false, "NCRResolutionCodeGroupChanges", 1048873, true, false, false, null)]
    protected NCRResolutionCodeGroupChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupMaint_Environment_ObjectToChange")]
    [Metadata("A User Code Object Group that represents a group of NCRResolutionCodes.", "NCRResolutionCodeGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("A User Code Object Group that represents a group of NCRResolutionCodes.", "NCRResolutionCodeGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeGroupMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public NCRResolutionCodeGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NCRResolutionCodeGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
