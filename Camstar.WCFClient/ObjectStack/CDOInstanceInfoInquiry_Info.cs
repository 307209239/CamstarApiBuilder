// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOInstanceInfoInquiry_Info
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
  public class CDOInstanceInfoInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Info_CDOInstanceInfo")]
    protected CDOInstanceInfo_Info _CDOInstanceInfo;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Info_SubentityDepthToProcess")]
    protected Info _SubentityDepthToProcess;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Info_CDOTypeName")]
    protected Info _CDOTypeName;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Info_InstanceName")]
    protected Info _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Info_Revision")]
    protected Info _Revision;

    public CDOInstanceInfo_Info CDOInstanceInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOInstanceInfo), (object) value);
      }
      get
      {
        return (CDOInstanceInfo_Info) this.PropertyGet(nameof (CDOInstanceInfo));
      }
    }

    public Info SubentityDepthToProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubentityDepthToProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubentityDepthToProcess));
      }
    }

    public Info CDOTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDOTypeName));
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

    public Info Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Revision));
      }
    }
  }
}
