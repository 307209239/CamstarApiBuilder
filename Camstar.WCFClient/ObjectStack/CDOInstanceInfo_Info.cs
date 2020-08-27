// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOInstanceInfo_Info
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
  public class CDOInstanceInfo_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_Info_Fields")]
    protected CDOField_Info _Fields;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_Info_InstanceRevision")]
    protected Info _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_Info_IsROR")]
    protected Info _IsROR;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfo_Info_InstanceName")]
    protected Info _InstanceName;

    public CDOField_Info Fields
    {
      [param: In] set
      {
        this.PropertySet(nameof (Fields), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (Fields));
      }
    }

    public Info InstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceRevision));
      }
    }

    public Info IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsROR));
      }
    }

    public Info InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceName));
      }
    }
  }
}
