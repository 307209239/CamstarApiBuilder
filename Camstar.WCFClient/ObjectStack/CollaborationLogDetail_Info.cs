// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaborationLogDetail_Info
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
  public class CollaborationLogDetail_Info : ProcessLogDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_Info_ToRole")]
    protected Info _ToRole;
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_Info_FromRole")]
    protected Info _FromRole;
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_Info_CollaborationDate")]
    protected Info _CollaborationDate;
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_Info_ToUser")]
    protected Info _ToUser;
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_Info_FromUser")]
    protected Info _FromUser;

    public Info ToRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToRole));
      }
    }

    public Info FromRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromRole));
      }
    }

    public Info CollaborationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaborationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollaborationDate));
      }
    }

    public Info ToUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToUser), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToUser));
      }
    }

    public Info FromUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromUser), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromUser));
      }
    }
  }
}
