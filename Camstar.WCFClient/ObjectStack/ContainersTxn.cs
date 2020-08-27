// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainersTxn
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
  public class ContainersTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_UserQuery")]
    protected NamedObjectRef _UserQuery;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_UserQueryText")]
    protected Primitive<string> _UserQueryText;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Services")]
    protected ContainerTxn[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_ContainerSearchFilters")]
    protected ContainerSearchDetail _ContainerSearchFilters;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_UserQueryGroup")]
    protected NamedObjectRef _UserQueryGroup;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_ContainerSearchDetails")]
    protected ContainerSearchDetail[] _ContainerSearchDetails;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_UserQueryParameters")]
    protected UserQueryParameterValues[] _UserQueryParameters;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Containers")]
    protected ContainerRef[] _Containers;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_ProcessIndividualESignatures")]
    protected Primitive<bool> _ProcessIndividualESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_ProcessESignatures")]
    protected new Primitive<bool> _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_PrintLabels")]
    protected new Primitive<bool> _PrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_UserQueryDescription")]
    protected Primitive<string> _UserQueryDescription;

    public override bool Equals(object obj)
    {
      return obj is ContainersTxn && object.Equals((object) this._PrintQueue, (object) ((ContainersTxn) obj)._PrintQueue) && (object.Equals((object) this._UserQuery, (object) ((ContainersTxn) obj)._UserQuery) && object.Equals((object) this._UserQueryText, (object) ((ContainersTxn) obj)._UserQueryText)) && (this.CompareArrays((Array) this._Services, (Array) ((ContainersTxn) obj)._Services) && object.Equals((object) this._ContainerSearchFilters, (object) ((ContainersTxn) obj)._ContainerSearchFilters) && (object.Equals((object) this._UserQueryGroup, (object) ((ContainersTxn) obj)._UserQueryGroup) && this.CompareArrays((Array) this._ContainerSearchDetails, (Array) ((ContainersTxn) obj)._ContainerSearchDetails))) && (this.CompareArrays((Array) this._UserQueryParameters, (Array) ((ContainersTxn) obj)._UserQueryParameters) && this.CompareArrays((Array) this._Containers, (Array) ((ContainersTxn) obj)._Containers) && (object.Equals((object) this._ProcessIndividualESignatures, (object) ((ContainersTxn) obj)._ProcessIndividualESignatures) && object.Equals((object) this._ProcessESignatures, (object) ((ContainersTxn) obj)._ProcessESignatures)) && (object.Equals((object) this._PrintLabels, (object) ((ContainersTxn) obj)._PrintLabels) && object.Equals((object) this._UserQueryDescription, (object) ((ContainersTxn) obj)._UserQueryDescription))) && base.Equals(obj);
    }

    public new NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public NamedObjectRef UserQuery
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQuery), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UserQuery));
      }
    }

    public Primitive<string> UserQueryText
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserQueryText));
      }
    }

    public ContainerTxn[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ContainerTxn[]) this.PropertyGet(nameof (Services));
      }
    }

    public ContainerSearchDetail ContainerSearchFilters
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSearchFilters), (object) value);
      }
      get
      {
        return (ContainerSearchDetail) this.PropertyGet(nameof (ContainerSearchFilters));
      }
    }

    public NamedObjectRef UserQueryGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UserQueryGroup));
      }
    }

    public ContainerSearchDetail[] ContainerSearchDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSearchDetails), (object) value);
      }
      get
      {
        return (ContainerSearchDetail[]) this.PropertyGet(nameof (ContainerSearchDetails));
      }
    }

    public UserQueryParameterValues[] UserQueryParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryParameters), (object) value);
      }
      get
      {
        return (UserQueryParameterValues[]) this.PropertyGet(nameof (UserQueryParameters));
      }
    }

    public ContainerRef[] Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (Containers));
      }
    }

    public Primitive<bool> ProcessIndividualESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessIndividualESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessIndividualESignatures));
      }
    }

    public new Primitive<bool> ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public new Primitive<bool> PrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabels), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PrintLabels));
      }
    }

    public Primitive<string> UserQueryDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserQueryDescription));
      }
    }
  }
}
