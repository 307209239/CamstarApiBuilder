// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainersTxn_Info
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
  public class ContainersTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_UserQuery")]
    protected Info _UserQuery;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_UserQueryText")]
    protected Info _UserQueryText;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_Services")]
    protected ContainerTxn_Info _Services;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_ContainerSearchFilters")]
    protected ContainerSearchDetail_Info _ContainerSearchFilters;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_UserQueryGroup")]
    protected Info _UserQueryGroup;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_ContainerSearchDetails")]
    protected ContainerSearchDetail_Info _ContainerSearchDetails;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_UserQueryParameters")]
    protected UserQueryParameterValues_Info _UserQueryParameters;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_Containers")]
    protected Info _Containers;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_ProcessIndividualESignatures")]
    protected Info _ProcessIndividualESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_ProcessESignatures")]
    protected new Info _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_PrintLabels")]
    protected new Info _PrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Info_UserQueryDescription")]
    protected Info _UserQueryDescription;

    public new Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Info UserQuery
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQuery), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserQuery));
      }
    }

    public Info UserQueryText
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserQueryText));
      }
    }

    public ContainerTxn_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ContainerTxn_Info) this.PropertyGet(nameof (Services));
      }
    }

    public ContainerSearchDetail_Info ContainerSearchFilters
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSearchFilters), (object) value);
      }
      get
      {
        return (ContainerSearchDetail_Info) this.PropertyGet(nameof (ContainerSearchFilters));
      }
    }

    public Info UserQueryGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserQueryGroup));
      }
    }

    public ContainerSearchDetail_Info ContainerSearchDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSearchDetails), (object) value);
      }
      get
      {
        return (ContainerSearchDetail_Info) this.PropertyGet(nameof (ContainerSearchDetails));
      }
    }

    public UserQueryParameterValues_Info UserQueryParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryParameters), (object) value);
      }
      get
      {
        return (UserQueryParameterValues_Info) this.PropertyGet(nameof (UserQueryParameters));
      }
    }

    public Info Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Containers));
      }
    }

    public Info ProcessIndividualESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessIndividualESignatures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessIndividualESignatures));
      }
    }

    public new Info ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public new Info PrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabels), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintLabels));
      }
    }

    public Info UserQueryDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserQueryDescription));
      }
    }
  }
}
