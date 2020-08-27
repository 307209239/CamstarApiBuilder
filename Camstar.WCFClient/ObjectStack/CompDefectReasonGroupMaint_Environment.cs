// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDefectReasonGroupMaint_Environment
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
  public class CompDefectReasonGroupMaint_Environment : UserCodeGroupMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CompDefectReasonGroupMaint_Environment_ObjectListInquiry")]
    [Metadata("A User Code Object Group that represents a group of Component Defect Reasons.", "ComponentDefectReasonGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("A User Code Object Group that represents a group of Component Defect Reasons.", "ComponentDefectReasonGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompDefectReasonGroupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CompDefectReasonGroupMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO for ComponentDefectReasonGroup.", "CompDefectReasonGroupChanges", false, false, false, "CompDefectReasonGroupChanges", 1048873, true, false, false, null)]
    protected CompDefectReasonGroupChanges_Environment _ObjectChanges;

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

    public CompDefectReasonGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (CompDefectReasonGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
