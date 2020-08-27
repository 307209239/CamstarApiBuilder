// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DefectDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ComponentDefectDetail_Info))]
  [KnownType(typeof (ContainerDefectDetail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class DefectDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DefectDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "DefectDetail_Info_DefectCount")]
    protected Info _DefectCount;
    [DataMember(EmitDefaultValue = false, Name = "DefectDetail_Info_ReasonCode")]
    protected Info _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DefectDetail_Info_Comment")]
    protected Info _Comment;

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info DefectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefectCount));
      }
    }

    public Info ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReasonCode));
      }
    }

    public Info Comment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comment));
      }
    }
  }
}
