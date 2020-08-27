// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRDefectDetails_Info
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
  public class NCRDefectDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Info_ActualComponentIssue")]
    protected Info _ActualComponentIssue;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Info_NCRDefectData")]
    protected Info _NCRDefectData;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Info_IsDefect")]
    protected Info _IsDefect;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Info_Lot")]
    protected Info _Lot;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Info_Product")]
    protected Info _Product;

    public Info ActualComponentIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualComponentIssue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualComponentIssue));
      }
    }

    public Info NCRDefectData
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRDefectData));
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

    public Info IsDefect
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefect), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsDefect));
      }
    }

    public Info Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Lot));
      }
    }

    public Info ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReferenceDesignator));
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
