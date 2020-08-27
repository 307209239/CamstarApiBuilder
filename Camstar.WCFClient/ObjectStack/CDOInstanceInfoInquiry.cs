// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOInstanceInfoInquiry
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
  public class CDOInstanceInfoInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_CDOInstanceInfo")]
    protected CDOInstanceInfo _CDOInstanceInfo;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_SubentityDepthToProcess")]
    protected Primitive<int> _SubentityDepthToProcess;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_CDOTypeName")]
    protected Primitive<string> _CDOTypeName;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_InstanceName")]
    protected Primitive<string> _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "CDOInstanceInfoInquiry_Revision")]
    protected Primitive<string> _Revision;

    public override bool Equals(object obj)
    {
      return obj is CDOInstanceInfoInquiry && object.Equals((object) this._CDOInstanceInfo, (object) ((CDOInstanceInfoInquiry) obj)._CDOInstanceInfo) && (object.Equals((object) this._SubentityDepthToProcess, (object) ((CDOInstanceInfoInquiry) obj)._SubentityDepthToProcess) && object.Equals((object) this._CDOTypeName, (object) ((CDOInstanceInfoInquiry) obj)._CDOTypeName)) && (object.Equals((object) this._InstanceName, (object) ((CDOInstanceInfoInquiry) obj)._InstanceName) && object.Equals((object) this._Revision, (object) ((CDOInstanceInfoInquiry) obj)._Revision)) && base.Equals(obj);
    }

    public CDOInstanceInfo CDOInstanceInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOInstanceInfo), (object) value);
      }
      get
      {
        return (CDOInstanceInfo) this.PropertyGet(nameof (CDOInstanceInfo));
      }
    }

    public Primitive<int> SubentityDepthToProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubentityDepthToProcess), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SubentityDepthToProcess));
      }
    }

    public Primitive<string> CDOTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CDOTypeName));
      }
    }

    public Primitive<string> InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceName));
      }
    }

    public Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }
  }
}
