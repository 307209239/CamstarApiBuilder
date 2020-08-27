// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Combine_Info
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
  public class Combine_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Combine_Info_FromContainerDetails")]
    protected CombineFromDetail_Info _FromContainerDetails;
    [DataMember(EmitDefaultValue = false, Name = "Combine_Info_EligibleContainersInquiry")]
    protected EligibleContainersInquiry_Info _EligibleContainersInquiry;
    [DataMember(EmitDefaultValue = false, Name = "Combine_Info_CloseWhenEmpty")]
    protected Info _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "Combine_Info_CombineType")]
    protected Info _CombineType;
    [DataMember(EmitDefaultValue = false, Name = "Combine_Info_AllowZeroQtys")]
    protected Info _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "Combine_Info_Container")]
    protected new Info _Container;

    public CombineFromDetail_Info FromContainerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainerDetails), (object) value);
      }
      get
      {
        return (CombineFromDetail_Info) this.PropertyGet(nameof (FromContainerDetails));
      }
    }

    public EligibleContainersInquiry_Info EligibleContainersInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (EligibleContainersInquiry), (object) value);
      }
      get
      {
        return (EligibleContainersInquiry_Info) this.PropertyGet(nameof (EligibleContainersInquiry));
      }
    }

    public Info CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Info CombineType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CombineType));
      }
    }

    public Info AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public new Info Container
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
  }
}
