// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OccupationMaint_Environment
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
  public class OccupationMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("A list of jobs available for selection in the MedWatch report.", "Occupation", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OccupationMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A list of jobs available for selection in the MedWatch report.", "Occupation", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OccupationMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "OccupationMaint_Environment_ObjectChanges")]
    [Metadata("A list of jobs available for selection in the MedWatch report.", "OccupationChanges", false, false, false, "OccupationChanges", 1048873, true, false, false, null)]
    protected OccupationChanges_Environment _ObjectChanges;

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

    public OccupationChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (OccupationChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
