// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DefectDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ComponentDefectDetail))]
  [KnownType(typeof (ContainerDefectDetail))]
  [Serializable]
  public class DefectDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "DefectDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "DefectDetail_DefectCount")]
    protected Primitive<int> _DefectCount;
    [DataMember(EmitDefaultValue = false, Name = "DefectDetail_ReasonCode")]
    protected NamedObjectRef _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DefectDetail_Comment")]
    protected Primitive<string> _Comment;

    public override bool Equals(object obj)
    {
      return obj is DefectDetail && object.Equals((object) this._Container, (object) ((DefectDetail) obj)._Container) && (object.Equals((object) this._DefectCount, (object) ((DefectDetail) obj)._DefectCount) && object.Equals((object) this._ReasonCode, (object) ((DefectDetail) obj)._ReasonCode)) && object.Equals((object) this._Comment, (object) ((DefectDetail) obj)._Comment) && base.Equals(obj);
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<int> DefectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DefectCount));
      }
    }

    public NamedObjectRef ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReasonCode));
      }
    }

    public Primitive<string> Comment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comment));
      }
    }
  }
}
