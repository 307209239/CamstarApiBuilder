// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainersTxn_Environment
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
  public class ContainersTxn_Environment : ShopFloor_Environment
  {
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, true, "NamedObjectRef", 1050609, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_PrintQueue")]
    protected new Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_UserQuery")]
    [Metadata("Predefined query defined using the Web Modeler application or using the new Web UI infrastructure and stored as Instance Data.  Note that the query definition is defined as instance data; the query itself can be used to retrieve information from either instance data tables or metadata tables.\r\nField UserQueryParameters will be implemented as a persistent list so that the parameter sequence will be automatically maintained by the corresponding persistent list table.", "UserQuery", false, false, false, "NamedObjectRef", 1050373, false, false, true, null)]
    protected Environment _UserQuery;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_UserQueryText")]
    [Metadata("Query Text.", "", false, false, true, "String", 1052936, false, false, false, null)]
    protected Environment _UserQueryText;
    [Metadata("Services that update or create containers.  Container updates always write out history information.", "ContainerTxn", false, false, false, "ContainerTxn", 1052702, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_Services")]
    protected ContainerTxn_Environment _Services;
    [Metadata("Container Search filters and results", "ContainerSearchDetail", false, false, false, "ContainerSearchDetail", 1052701, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_ContainerSearchFilters")]
    protected ContainerSearchDetail_Environment _ContainerSearchFilters;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_UserQueryGroup")]
    [Metadata("Used to create groupings of user queries. Usually used to group outputs.", "UserQueryGroup", false, false, false, "NamedObjectRef", 1052829, false, false, true, null)]
    protected Environment _UserQueryGroup;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_ContainerSearchDetails")]
    [Metadata("Container Search filters and results", "ContainerSearchDetail", false, false, false, "ContainerSearchDetail", 1052700, false, true, true, null)]
    protected ContainerSearchDetail_Environment _ContainerSearchDetails;
    [Metadata("Values for the parameters used by a UserQuery.", "UserQueryParameterValues", false, false, false, "UserQueryParameterValues", 1052830, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_UserQueryParameters")]
    protected UserQueryParameterValues_Environment _UserQueryParameters;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_Containers")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1048623, false, true, false, null)]
    protected Environment _Containers;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053059, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_ProcessIndividualESignatures")]
    protected Environment _ProcessIndividualESignatures;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050357, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_ProcessESignatures")]
    protected new Environment _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_PrintLabels")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050625, false, false, false, "1")]
    protected new Environment _PrintLabels;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1052935, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainersTxn_Environment_UserQueryDescription")]
    protected Environment _UserQueryDescription;

    public new Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Environment UserQuery
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQuery), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserQuery));
      }
    }

    public Environment UserQueryText
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserQueryText));
      }
    }

    public ContainerTxn_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ContainerTxn_Environment) this.PropertyGet(nameof (Services));
      }
    }

    public ContainerSearchDetail_Environment ContainerSearchFilters
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSearchFilters), (object) value);
      }
      get
      {
        return (ContainerSearchDetail_Environment) this.PropertyGet(nameof (ContainerSearchFilters));
      }
    }

    public Environment UserQueryGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserQueryGroup));
      }
    }

    public ContainerSearchDetail_Environment ContainerSearchDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSearchDetails), (object) value);
      }
      get
      {
        return (ContainerSearchDetail_Environment) this.PropertyGet(nameof (ContainerSearchDetails));
      }
    }

    public UserQueryParameterValues_Environment UserQueryParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryParameters), (object) value);
      }
      get
      {
        return (UserQueryParameterValues_Environment) this.PropertyGet(nameof (UserQueryParameters));
      }
    }

    public Environment Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Containers));
      }
    }

    public Environment ProcessIndividualESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessIndividualESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessIndividualESignatures));
      }
    }

    public new Environment ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public new Environment PrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabels), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintLabels));
      }
    }

    public Environment UserQueryDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserQueryDescription));
      }
    }
  }
}
