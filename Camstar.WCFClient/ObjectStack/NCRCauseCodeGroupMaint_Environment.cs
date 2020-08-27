// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCauseCodeGroupMaint_Environment
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
  public class NCRCauseCodeGroupMaint_Environment : UserCodeGroupMaint_Environment
  {
    [Metadata("A User Code Object Group that represents a group of NCRCauseCodes.", "NCRCauseCodeGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A User Code Object Group that represents a group of NCRCauseCodes.", "NCRCauseCodeGroupChanges", false, false, false, "NCRCauseCodeGroupChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupMaint_Environment_ObjectChanges")]
    protected NCRCauseCodeGroupChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeGroupMaint_Environment_ObjectListInquiry")]
    [Metadata("A User Code Object Group that represents a group of NCRCauseCodes.", "NCRCauseCodeGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;

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

    public NCRCauseCodeGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NCRCauseCodeGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
