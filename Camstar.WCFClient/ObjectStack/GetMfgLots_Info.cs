// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMfgLots_Info
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
  public class GetMfgLots_Info : GetMfgData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Info_MfgDataDetails")]
    protected MfgLotDetail_Info _MfgDataDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Info_IncludeWhereUsed")]
    protected Info _IncludeWhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Info_ToStartDate")]
    protected Info _ToStartDate;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Info_FromStartDate")]
    protected Info _FromStartDate;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Info_WorkCenter")]
    protected Info _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Info_Product")]
    protected Info _Product;

    public MfgLotDetail_Info MfgDataDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgDataDetails), (object) value);
      }
      get
      {
        return (MfgLotDetail_Info) this.PropertyGet(nameof (MfgDataDetails));
      }
    }

    public Info IncludeWhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeWhereUsed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeWhereUsed));
      }
    }

    public Info ToStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStartDate));
      }
    }

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

    public Info FromStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStartDate));
      }
    }

    public Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public Info WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }
  }
}
