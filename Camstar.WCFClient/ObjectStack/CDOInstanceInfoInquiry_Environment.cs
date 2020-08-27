// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOInstanceInfoInquiry_Environment
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
  public class CDOInstanceInfoInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Environment_CDOInstanceInfo")]
    [Metadata("Basic info for the requested modeling instance.", "CDOInstanceInfo", false, false, true, "CDOInstanceInfo", 16778281, false, false, false, null)]
    protected CDOInstanceInfo_Environment _CDOInstanceInfo;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Environment_SubentityDepthToProcess")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778282, false, false, false, "1")]
    protected Environment _SubentityDepthToProcess;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1050800, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Environment_CDOTypeName")]
    protected Environment _CDOTypeName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1053067, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Environment_InstanceName")]
    protected Environment _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Environment_Revision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1048710, false, false, false, null)]
    protected Environment _Revision;

    public CDOInstanceInfo_Environment CDOInstanceInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOInstanceInfo), (object) value);
      }
      get
      {
        return (CDOInstanceInfo_Environment) this.PropertyGet(nameof (CDOInstanceInfo));
      }
    }

    public Environment SubentityDepthToProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubentityDepthToProcess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubentityDepthToProcess));
      }
    }

    public Environment CDOTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDOTypeName));
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

    public Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
      }
    }
  }
}
