// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOInstanceInfo_Environment
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
  public class CDOInstanceInfo_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_Environment_Fields")]
    [Metadata("Generic object for use in modeling inquiry to return a list of fields with values for a modeling instance.", "CDOField", false, false, false, "CDOField", 16778269, false, true, false, null)]
    protected CDOField_Environment _Fields;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_Environment_InstanceRevision")]
    protected Environment _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_Environment_IsROR")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, true, "Boolean", 1048708, false, false, false, "0")]
    protected Environment _IsROR;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1053067, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_Environment_InstanceName")]
    protected Environment _InstanceName;

    public CDOField_Environment Fields
    {
      [param: In] set
      {
        this.PropertySet(nameof (Fields), (object) value);
      }
      get
      {
        return (CDOField_Environment) this.PropertyGet(nameof (Fields));
      }
    }

    public Environment InstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceRevision));
      }
    }

    public Environment IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsROR));
      }
    }

    public Environment InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceName));
      }
    }
  }
}
